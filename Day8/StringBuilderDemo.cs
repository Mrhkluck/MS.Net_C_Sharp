using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day8
{
    internal class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(30);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.MaxCapacity);
            Console.WriteLine(sb);
            sb.AppendFormat("C sharp is {0}", "object oriented programming Langange");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.MaxCapacity);
            Console.WriteLine(sb);
            sb.AppendLine();
            sb.AppendLine("It is case sensitive");
            Console.WriteLine(sb);
            sb.Insert(47, "C sharp is event Driver");
            Console.WriteLine(sb);
        }
    }
}
