using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.MultiThreadExp
{
    internal class TaskUsingForLoop
    {
        static void Main(string[] args)
        {
            //DateTime.Parse()
            DateTime sTime = DateTime.Now;
            Console.WriteLine($"For Loop Execution started at :{sTime.ToLongTimeString()}");
            for(int i = 0; i < 10; i++)
            {
                long sum = DoTask();
                Console.WriteLine($"{i} =>{sum}");
            }
            DateTime eTime = DateTime.Now;
            Console.WriteLine($"For loop execution ended at:{eTime.ToLongTimeString()}");
            TimeSpan span = eTime - sTime;
            int msecond= Convert.ToInt32(span.TotalMilliseconds);
            Console.WriteLine($"Time taken to execute:{msecond}");
                
        }
         static long DoTask()
        {
            long sum = 0;    //2103453656346
            //for(int i = 0; i < Int32.MaxValue; i++) 
            for (int i = 0; i < 100000000; i++) 
            {
                sum = sum + 1;

            }
            return sum;

        }
      
    }
}
