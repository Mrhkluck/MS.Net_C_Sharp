using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//import Regular

namespace ConsoleDemoApp.Day8
{
    internal class StringDemo
    {
        static void Main(string[] args)
        {
            string str = "abcd1efgh43ijkl8340771129mnop88qrst77uvwz33yz";
            //123,43,56,88,77,33
            //regular Expression
            //Regex
            //Match
            //MatchCollection
            bool result = Regex.IsMatch(str, "\\d");//find decimal
            Console.WriteLine(result);

            result = Regex.IsMatch(str, "\\d{4}");//4 digit no @"\d" 0r "/d"
            Console.WriteLine(result);

            Console.WriteLine(str);
            Console.WriteLine("======================");
            //Match match = Regex.Match(str, @"\d{10}");
            //// Match match = Regex.Match(str, @"\d{2,}");
            // Console.WriteLine(match.Value);
            // Console.WriteLine(match.Success);
            // Console.WriteLine(match.Length);
            // match=match.NextMatch();
            // Console.WriteLine(match.Value);
            // match = match.NextMatch();
            // Console.WriteLine(match.Value);
            // match = match.NextMatch();
            // Console.WriteLine(match.Value);

            //Match Collection
            MatchCollection matches = Regex.Matches(str, @"\d{2,}");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            //Split
            Console.WriteLine("===========================");
            string[]splitdate = Regex.Split(str, @"\d{2,}");
            Console.WriteLine("split Data:");
            foreach (var data in splitdate)
            {
                Console.WriteLine(data);

            }

            //Replace
            Console.WriteLine("++++++++++++++++");
           string newstr=  Regex.Replace(str, @"\d{2,}", "_");
            Console.WriteLine(newstr);

            //Random
            Random rand = new Random();
            int num = rand.Next(50, 5000);
            Console.WriteLine("random:"+num);

            //Math class



        }
    }
}
