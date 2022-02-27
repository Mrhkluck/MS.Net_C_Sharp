using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
//using System.Runtime.CompilerServices;


namespace ConsoleDemoApp.MultiThreadExp
{
    class Test3
    {
        public static void Print(object ob) // Parameterize thread Delegate
        {
            Console.WriteLine("\nRunning Thread :"+ Thread.CurrentThread.Name + "\tPooled Thread:" + Thread.CurrentThread.IsThreadPoolThread);
            //Console.WriteLine("\tPooled Thread:"+ Thread.CurrentThread.IsThreadPoolThread);
        }

        public static void ProcessWithThreadMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                //Normal Thread Creation
                Thread obj = new Thread(new ParameterizedThreadStart(Test3.Print));
                obj.Name= "Th-" + i;
                obj.Start();
                //obj.Start("Th-"+i);
            }
        }
        public static void ProcessWithThreadPoolMethod()
        {
            for(int i = 0; i < 5; i++)
            {
                //Creating and Adding Threads in ThreadPool
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test3.Print));

            }
        }
    }
    internal class ThreadDemo2
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            Console.WriteLine("\nNormal Thread Execution:");
            watch.Start();
            Test3.ProcessWithThreadMethod();
            watch.Stop();
            Console.WriteLine("Total Time Consumed:"+watch.ElapsedMilliseconds);
            Console.WriteLine("Total Time Consumed:"+watch.ElapsedTicks);

            Console.WriteLine("\nThreadPool Execution:");
            watch.Start();
            Test3.ProcessWithThreadPoolMethod();
            watch.Stop ();
            Console.WriteLine("Total Time Consumed:" + watch.ElapsedMilliseconds);
            Console.WriteLine("Pooled Total Time Consumed:" + watch.ElapsedTicks);


            Console.WriteLine("Main End");
        }
    }
}
