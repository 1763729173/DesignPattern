﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTest
{
    class Program
    {
        static void Main(string[] args)
        {
            INoticer noticer = new NoticerA();
            noticer.addObserver(new ObserverA());
            noticer.addObserver(new ObserverB());

            noticer.notice();
            Console.ReadLine();
        }
    }
}