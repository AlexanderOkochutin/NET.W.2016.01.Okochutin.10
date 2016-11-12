using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Logic
{
    public sealed class Listner1
    {

        public Listner1()
        {
          
        }

        public void Register(TimerManager timer)
        {
            timer.Alarm += Listener1Messanger;
        }

        public void UnRegister(TimerManager timer)
        {
            timer.Alarm -= Listener1Messanger;
        }

        private void Listener1Messanger(object sender,AlarmEventArgs eventArgs)
        {
            Console.WriteLine(nameof(Listner1)+  " " + eventArgs.Message);
        }  
    }

    public sealed class Listner2
    {

        public Listner2()
        {

        }

        public void Register(TimerManager timer)
        {

            timer.Alarm += Listener2Messanger;
        }

        public void UnRegister(TimerManager timer)
        {
            timer.Alarm -= Listener2Messanger;
        }

        private void Listener2Messanger(object sender, AlarmEventArgs eventArgs)
        {
            Console.WriteLine(nameof(Listner2) + " " + eventArgs.Message);
        }
    }
}
