using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.DelegateDemo
{
   // public delegate void MyDel(int x);
   public delegate int MyDel(int x);
    public delegate int CalcDel(int n1, int n2);

    internal class DelegateDemo2
    {
        static void Main(string[] args)
        {
            //Anynomous Method
            //MyDel square = delegate (int num)
            //{
            //    Console.WriteLine($"Square of {num} is {num * num}"); //break,continue,goto
            //    //It can't access ref and out parameter of any outer parameter
            //};
            //square(5);

            //MyDel cube = delegate (int num)
            //{
            //    Console.WriteLine($"cube of {num} is {num * num * num}");
            //};
            //cube(6);


            //Lambda Expression
            MyDel square = (int n) => { return n * n; };

            int res = square(6); //calling
            Console.WriteLine($"Square of 6 is {res}");

            CalcDel add = (int x, int y) => { return x + y; };
            Console.WriteLine("result is:"+add(50,20));

        }
    }
}
