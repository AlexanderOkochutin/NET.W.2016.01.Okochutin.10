using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.CUI;

namespace Task01.Logic
{

    public sealed class Listner1
    {
        public string Name { get; }

        public Listner1(string name)
        {
            Name = name;
        }

        public void Register(TimerManager timer) => timer.Alarm += Listener1Messanger;

        public void UnRegister(TimerManager timer) => timer.Alarm -= Listener1Messanger;

        private  void Listener1Messanger(object sender,AlarmEventArgs eventArgs) => Console.WriteLine($"{nameof(Listner1)} {Name} get a new message: {eventArgs.Message}");

    }

    public sealed class Listner2
    {
        public string Name { get; }

        public Listner2(string name)
        {
            Name = name;
        }

        public void Register(TimerManager timer) => timer.Alarm += Listener2Messanger;

        public void UnRegister(TimerManager timer) => timer.Alarm -= Listener2Messanger;

        private void Listener2Messanger(object sender, AlarmEventArgs eventArgs) => Console.WriteLine($"{nameof(Listner2)} {Name} get a new message: {eventArgs.Message}");

    }
}
