using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day8
{
    internal class DateTimeDemo
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime(2022, 02, 21);
            //Console.WriteLine(dt);
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToString("MM/dd/yyyy"));//for month MM and for min mm
            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Year);
            dt= dt.AddMonths(5);
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToString("dddd,MMMM,yy"));
            Console.WriteLine(dt.ToString("dd,MM,yy,HH:mm:ss"));
            Console.WriteLine(dt.ToString("dd,MM,yy,HH:mm:ss tt"));
            Console.WriteLine(dt.ToString("dd,MM,yy,HH:mm:ss GMT"));

        }
    }
}
