using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            /* int x = -10; //10+1=>11   -10
             //00001010
             //11110101
             //00001010
             //        +1
             //00001011=>-11
             Console.WriteLine(~x);//1,s complement
             //11110101
             //      +1
             //11110110

             //00001001
             //      +1
             //00001010=>-10
             Console.WriteLine(~x+1);//2's complement

             int a = 30, b = 20;
             Console.WriteLine( a+~b+1);

             int z = a++ + ++b;
             Console.WriteLine(z);
            */

            object str = "cdac";

            //string  mystr   = str; not aplicable because of object to string

            //string mystr=(string)str;

            string mystr = str as string; //for downcasting
            Console.WriteLine(mystr);

            int? x = 20;
            if(x is null)
            {
                Console.WriteLine(mystr);
            }
            if(mystr is string)
                Console.WriteLine(mystr);

            Console.WriteLine(typeof(string));
            Console.WriteLine(sizeof(decimal)); 

            Type tp = typeof(int);//System.Int32
            Console.WriteLine(tp.Name);
            Console.WriteLine(tp.Namespace);    

            string str2 = "Cdac";
            Console.WriteLine(str2.GetType());
            

        }
    }
}
