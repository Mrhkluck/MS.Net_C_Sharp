using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleDemoApp.LinqExp
{
    internal class ArrayListDemo2
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 10, 15, 30, 20, 45, 65, 80 };
            Console.WriteLine("List Data Using normal loops:");
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("List Data using Foreach:");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List Data using Iteration:");
            IEnumerator iteartor= list.GetEnumerator();
            //iteartor.MoveNext();
            //Console.WriteLine(iteartor.Current);
            //iteartor.MoveNext();
            //Console.WriteLine(iteartor.Current);
            while (iteartor.MoveNext())//in java we use hashnext
            {
                Console.WriteLine(iteartor.Current);
            }
            int thirddata =(int)list[2]; //boxing- it take time . collection are not type spacific so we use (int) to unboxing we do(int)
            Console.WriteLine("Third item:"+thirddata);

        }
    }
}
