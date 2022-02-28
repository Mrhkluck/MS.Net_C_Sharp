using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.MultiThreadExp
{
    internal class ParallelForEachDemo
    {
        static void Main(string[] args)
        {
           List<int>list =  Enumerable.Range(10, 20).ToList();
            Console.WriteLine("Using Foreach:");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Using Parallel Foreach");
            Parallel.ForEach(list, item => {
                Console.WriteLine(item);
            });
        }
    }
}
