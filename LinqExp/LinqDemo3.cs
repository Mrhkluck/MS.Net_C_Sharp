using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleDemoApp.Day7;

namespace ConsoleDemoApp.LinqExp
{
    internal class LinqDemo3
    {
        static void Main(string[] args)
        {
            IList<string> names = new List<string>()
            {
                "Mrhkluck",
                "Rashid khan",
                "Humayun",
                "Muni Khan",
                "Chuni Hihkole"
            };

            var result = from name in names
                         where name.EndsWith("khan") orderby name ascending
                         select name;

            foreach(var item in result)
                Console.WriteLine(item);

        }
    }
}
