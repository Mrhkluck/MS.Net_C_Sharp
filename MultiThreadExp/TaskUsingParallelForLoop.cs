using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.MultiThreadExp
{
    internal class TaskUsingParallelForLoop
    {
        static void Main(string[] args)
        {
            //DateTime.Parse()
            DateTime sTime = DateTime.Now;
            Console.WriteLine($"Parallel For Loop Execution started at :{sTime.ToLongTimeString()}");
            //for (int i = 0; i < 10; i++)
            //{
            //    long sum = DoTask();
            //    Console.WriteLine($"{i} =>{sum}");
            //}
            //Parallel.For()
            //ParallelOptions options = new ParallelOptions();
            var options = new ParallelOptions() {
                MaxDegreeOfParallelism = 3
            };

            Parallel.For(0, 10,options,i => {
                long sum = DoTask();
                Console.WriteLine($"{i} =>{sum}");

            });

            //Parallel.For(0, 10, i => { 
            //    long sum = DoTask();
            //    Console.WriteLine($"{i} =>{sum}");

            //});

            DateTime eTime = DateTime.Now;
            Console.WriteLine($"Parallel For loop execution ended at:{eTime.ToLongTimeString()}");
            TimeSpan span = eTime - sTime;
            int msecond = Convert.ToInt32(span.TotalMilliseconds);
            Console.WriteLine($"Parallel Time taken to execute:{msecond}");

        }
        static long DoTask()
        {
            long sum = 0;    //2103453656346
            for(int i = 0; i < Int32.MaxValue; i++) 
           // for (int i = 0; i < 100000000; i++)
            {
                sum = sum + 1;

            }
            return sum;

        }
    }
}
