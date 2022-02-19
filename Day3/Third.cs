using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day3
{
    enum Month
    {
        Jan,Feb,March, April, May, June
    }
    internal class Third
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Password");
            //ConsoleKeyInfo ck = Console.ReadKey();//display passed keychar on console
            //ConsoleKey and ConsoleKeyInfo are defined in system namespace
            ConsoleKeyInfo ck = Console.ReadKey(true);//hide pressed keychar on console
            string password = "";
            while (ck.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                password += ck.KeyChar;
                ck= Console.ReadKey(true);

            }
            Console.WriteLine("\nEntered Password:" + password);
          /*  //Month.Jan
            //ConsoleKey.
            Console.WriteLine("\nPassed Key:" + ck.Key);//ConsoleKey

            if(ConsoleKey.Enter!=ck.Key)    
            Console.WriteLine("KeyChar:"+ck.KeyChar);//Char
          */
        }
    }
}
