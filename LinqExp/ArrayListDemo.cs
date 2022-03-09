using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleDemoApp.LinqExp
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList list =new ArrayList(5);
            Console.WriteLine(list.Count);//0  0
            Console.WriteLine(list.Capacity);//0   5
            list.Add(20);
            Console.WriteLine($"Current count:{list.Count}");//1  1
            Console.WriteLine($"Current Capacity:{list.Capacity}");//4   5 
            int[] arr = {1,2,5,6};
            list.AddRange(arr);
            //0 4 8 16 32 64 128 256 ....
            Console.WriteLine("............................");
            Console.WriteLine($"Current count:{list.Count}");//5  ,4  5
            Console.WriteLine($"Current Capacity:{list.Capacity}");//8  ,5

            list.Add(25);
            //5 10 20 40 80 160 320
            Console.WriteLine("............................");
            Console.WriteLine($"Current count:{list.Count}");//6
            Console.WriteLine($"Current Capacity:{list.Capacity}");//10
            // to removove extra memory
            list.TrimToSize();
            Console.WriteLine("............................");
            Console.WriteLine($"Current count:{list.Count}");
            Console.WriteLine($"Current Capacity:{list.Capacity}");
            list.Add(45);
            list.Add(45);

            list.Add(45);
            //5 10 20 40 80 160 320
            Console.WriteLine("............................");
            Console.WriteLine($"Current count:{list.Count}");//7
            Console.WriteLine($"Current Capacity:{list.Capacity}");//12
            list.AddRange(arr);
            list.Add(45);
            list.Add(45);
            Console.WriteLine("............................");
            Console.WriteLine($"Current count:{list.Count}");//13
            Console.WriteLine($"Current Capacity:{list.Capacity}");//24
            

        }
    }
}
