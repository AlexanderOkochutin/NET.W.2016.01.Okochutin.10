using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Task01.Logic;

namespace Task01.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var timerManager = new TimerManager(20);
            var lstn1 = new Listner1();
            var lstn2 = new Listner2();
            var lstn3 = new Listner1();
            lstn1.Register(timerManager);
            lstn2.Register(timerManager);
            timerManager.StartCountDown("Time is over");
            Thread.Sleep(5000);
            lstn3.Register(timerManager);
            Console.ReadLine();
        }
    }
}
