﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleDemoApp.MultiThreadExp
{
    class Test1
    {
        public void Print()
        {
            lock (this)
            {
                int i = 1;
                for (;i<=5 ; )
                {
                    Console.WriteLine($"Running Thread :{Thread.CurrentThread.Name},from test1 :{i++}");
                    Thread.Sleep(1000);
                }
            }
        }
        public void CheckCase()
        {
            string str = "This Is POWER Of MultiThreading In C Sharp";
            foreach (char ch in str)
            {
                Console.Write(ch);
                int code = (int)ch;
                if (code >= 97 && code <= 122)
                {
                    code = code - 32;
                    Thread.Sleep(800);
                    Console.Write("\b");
                    Console.Write((char)code);
                }
                Thread.Sleep(300);
            }
        }

    }
    class Test2
    {
        public void Print()
        {
            int i = 1;
            for (; ; )
            {
                Console.WriteLine($"Running Thread :{Thread.CurrentThread.Name},from test2 :{i*i}");
                i++;
                Thread.Sleep(1000);
            }
        }

    }
    internal class ThreadDemo1
    {
        static void Main(string[] args)
        {
            //    Thread t1 = Thread.CurrentThread;
            //    //t1.Name = "Main Thread";
            //    //t1.Priority = ThreadPriority.Highest;
            //    Console.WriteLine("Name:" +t1.Name);
            //    Console.WriteLine("Priority:" + t1.Priority);
            //    Console.WriteLine("IsAlive:" + t1.IsAlive);
            //    Console.WriteLine("Background:" + t1.IsBackground);
            //    Console.WriteLine("Current Thread State:" + t1.ThreadState);
            //    Console.WriteLine("Is Pooles Thread:"+t1.IsThreadPoolThread);

            Console.WriteLine("Main started");
            Test1 t1 = new Test1();
            Test2 t2 = new Test2();
            //t1.Print();
            //t2.Print();

            //Create Thread
            // Thread th1 = new Thread(new ThreadStart(t1.Print)); //delegate instance
            Thread th1 = new Thread(t1.Print); //Binding resource with thread
            th1.Name = "TH-1";

            Thread th2 = new Thread(t1.Print);
            th2.Name = "TH-2";

            th1.Start();
            th2.Start();

            // Thread th3 = new Thread(t2.Print); //Binding resource with thread
            // th3.Name = "TH-3";

            // Thread th4 = new Thread(t2.Print);
            // th4.Name = "TH-4";


            // th3.Start();
            // th4.Start();

            //Thread th = new Thread(t1.CheckCase);
            //th.Start();


            Console.WriteLine( "Main ended");
        }
    }
}
