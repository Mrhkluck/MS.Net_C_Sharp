using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleDemoApp.MultiThreadExp
{
    class Test4
    {
        public void Print()
        {
            lock (this)
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Runnung Thread:"+
                        $"{Thread.CurrentThread.Name}\tvalue of i:{i}");
                }
                //Setting Random value to GetRandom Property
                GetRandom = new Random().Next(1, 50);
                Monitor.Pulse(this); //Notifier the thread that is in queue
            }
        }
        public int GetRandom
        {
            get;
            set;    
        }
    }
    internal class ThreadDemo3
    {
        static void Main(string[] args)
        {
            Test4 t4 = new Test4();
            Thread th1 = new Thread(t4.Print);
            th1.Name = "Thread-1";
            th1.Start();

            Thread th2 = Thread.CurrentThread;
            th2.Name = "Main Thread";

            lock (t4)
            {
                Monitor.Wait(t4);//Wait for resources to be free
                //any value within given,0
                Console.WriteLine("In Main");
                for(int i =0; i < t4.GetRandom; i++)
                {
                    Console.WriteLine($"Running Thread:{Thread.CurrentThread.Name}\tvalue of i:{i}");
                }
            }
        }
    }
}
