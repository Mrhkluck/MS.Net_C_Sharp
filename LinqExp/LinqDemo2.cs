using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleDemoApp.Day7;

namespace ConsoleDemoApp.LinqExp
{
    internal class LinqDemo2
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][]
            {
                new int[] { 1, 2, 3 ,4},
                new int[] { 2,4},
                new int[] {9,10,11}

            };

            //Linq to Entity
            var maxarr = arr.Select(v => v.Max()).ToArray();
            foreach(var item in maxarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
