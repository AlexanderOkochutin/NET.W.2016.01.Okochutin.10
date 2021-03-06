﻿using System;
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
            var timerManager = new TimerManager(10);
            var lstn1 = new Listner1("Jonh");
            var lstn2 = new Listner2("Sara");
            var lstn3 = new Listner1("Smith");
            lstn1.Register(timerManager);
            lstn2.Register(timerManager);
            timerManager.StartCountDown();
            Thread.Sleep(15000);
            lstn3.Register(timerManager);
            timerManager.StartCountDown();
            timerManager.ResetTimer();
            timerManager.StartCountDown();
            Console.ReadLine();
        }
    }
}
