using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task01.Logic
{
    #region AlarmEventArgs

    public sealed class AlarmEventArgs : EventArgs
    {
        public string Message { get; }

        public AlarmEventArgs() : this("Alarm") { }

        public AlarmEventArgs(string message)
        {
            Message = message;
        }
    }

    #endregion

    #region Time Manager

    public class TimerManager
    {
        public event EventHandler<AlarmEventArgs> Alarm = delegate { };

        public TimeSpan StartTime { get; }
    
        public TimeSpan RemainingTime { get; private set; }

        public bool IsDisplayed = true;

        protected virtual void OnAlarm(AlarmEventArgs eventArgs)
        {
            EventHandler<AlarmEventArgs> temp = Alarm;
            temp?.Invoke(this,eventArgs);
        }

        #region Constructors

        public TimerManager(int seconds) : this(0, 0, seconds) { }

        public TimerManager(int minutes, int seconds) : this(0, minutes, seconds) { }

        public TimerManager(int hours, int minutes, int seconds)
        {
            StartTime = new TimeSpan(hours,minutes,seconds);
            RemainingTime = StartTime;
        }

        #endregion

        public async void StartCountDown(string Message)
        {
            while (RemainingTime >= TimeSpan.Zero)
            {
                if (IsDisplayed)
                {
                    Console.WriteLine(RemainingTime);
                    await Task.Run(() => Tick());
                    //Tick();
                    Console.Clear();
                }
                else
                {
                    await Task.Run(() => Tick());
                    //Tick();
                }
            }
            OnAlarm(new AlarmEventArgs(Message));
        }

        private void Tick()
        {
            RemainingTime -= TimeSpan.FromSeconds(1);
            Thread.Sleep(1000);
        }
    }

    #endregion
}
