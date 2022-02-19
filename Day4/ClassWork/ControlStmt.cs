using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class ControlStmt
    {
        static void Main(string[] args)
        {
            //  char ch;
            //Console.WriteLine("Enter any char:");
            //Console.WriteLine("Enter any weekday:");
            //weekday =Console.ReadLine();
            //ch = Char.Parse(Console.ReadLine());
            //switch (ch)
            // {
            //  default:
            //   Console.WriteLine("Invalid");
            // break;
            //case 'a':
            //Console.WriteLine("1");
            //break;
            //  case 'e':
            //Console.WriteLine("2");
            //break;
            //case 'i':
            //  Console.WriteLine($"enter char {ch} is vowel");
            //  break ;
            //default:
            //    Console.WriteLine("Invalid");
            //    break;
            // }

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("Array values are");
            //// foreach(Type identifier in CollectionMode - name
            ////     }

            ////forword only loop
            ////readonly
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Boxing
            //object obj = 20;//implicit
            //int y = (int)obj;//unboxing,explicit
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (object item in arr)
            {
                //item=item+2;//invalid
                Console.WriteLine(item.GetType());
                if ((int)item > 5)
                {
                    Console.WriteLine(item);

                }

            }
            Console.WriteLine("=====================");
            foreach (var item in arr)
            {
                Console.WriteLine(item.GetType());
                if (item>5)
                {
                    Console.WriteLine(item);

                }

            }
            Console.WriteLine("================");
            //dynamic obj;
            foreach (dynamic item in arr)
            {
                Console.WriteLine(item.GetType());
                if (item > 5)
                {
                    Console.WriteLine(item);

                }

            }

        }
    }
}
