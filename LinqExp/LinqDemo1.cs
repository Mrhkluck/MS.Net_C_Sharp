using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleDemoApp.Day7;

namespace ConsoleDemoApp.LinqExp
{
    internal class LinqDemo1
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 ,4,5,6,7,8,9,10,11};
            var evenNums = from number in numbers
                           where number % 2 == 0
                           select number;
            Console.WriteLine("Even number:");
            foreach(var item in evenNums)
            {
                Console.WriteLine(item);
            }
            ArrayList list = new ArrayList() { 
                10,"Noida","Patna",25,38,"Mumbai",
                30,new Product() {Pid= 1000}
            };
            list.Add(20);

            var nums = from n in list.OfType<int>()
                       where n % 2 == 1
                       select n;
            Console.WriteLine("List Data");
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }

        }
    }
}
