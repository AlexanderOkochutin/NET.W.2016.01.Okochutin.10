using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task01.Logic
{
    #region AlarmEventArgs

    /// <summary>
    /// Alarm Event let give a message to subscribers
    /// </summary>
    public sealed class AlarmEventArgs : EventArgs
    {
        /// <summary>
        /// Message which send to subscriber
        /// </summary>
        public string Message { get; }

        #region Constructors

        public AlarmEventArgs(string message)
        {
            Message = message;
        }

        #endregion
    }

    #endregion

    #region Time Manager

    /// <summary>
    /// Time manager wich simulate work of timer and send a message to subscribers on alarm
    /// </summary>
    public class TimerManager
    {
        public event EventHandler<AlarmEventArgs> Alarm = delegate { };

        /// <summary>
        /// message what will send to subscribers
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Start point to countdown
        /// </summary>
        public TimeSpan StartTime { get; }

        /// <summary>
        /// Current time in countdown process
        /// </summary>
        public TimeSpan RemainingTime { get; private set; }

        /// <summary>
        /// show countdown is over or not
        /// </summary>
        private bool timeOver;

        #region Constructors

        public TimerManager(int seconds, string message = "Alarm") : this(0, 0, seconds)
        {
        }

        public TimerManager(int minutes, int seconds, string message = "Alarm") : this(0, minutes, seconds)
        {
        }

        public TimerManager(int hours, int minutes, int seconds, string message = "Alarm")
        {
            StartTime = new TimeSpan(hours, minutes, seconds);
            RemainingTime = StartTime;
            timeOver = false;
            Message = message;
        }

        #endregion

        
        protected virtual void OnAlarm(AlarmEventArgs eventArgs)
        {
            EventHandler<AlarmEventArgs> temp = Volatile.Read(ref Alarm);
            temp?.Invoke(this, eventArgs);
        }


        /// <summary>
        /// method which start countdown from StartTime to 0
        /// </summary>
        public async void StartCountDown()
        {
            if (timeOver) return;
            while (RemainingTime >= TimeSpan.Zero)
            {
                await Task.Run(() => Tick());
            }
            OnAlarm(new AlarmEventArgs(Message));
            timeOver = true;
        }
        
        /// <summary>
        /// Method wich reset timer when time is over? let to startCountDown again
        /// </summary>
        public void ResetTimer()
        {
            if (!timeOver) return;
            timeOver = false;
            RemainingTime = StartTime;
        }

        /// <summary>
        /// Method which simulate one second freeze
        /// </summary>
        private void Tick()
        {
            RemainingTime -= TimeSpan.FromSeconds(1);
            Thread.Sleep(1000);
        }
    }

    #endregion
}
