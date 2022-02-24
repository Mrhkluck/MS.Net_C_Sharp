using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.DelegateDemo
{

    internal class DelegateDemo3
    {
        //static int Add(int x, int y , int z)
        //{
        //    return x + y + z;
        //}

        static void Add(int x,int y, int z)
        {
            Console.WriteLine("Sum is:"+x + y + z);
        }
        static void Main(string[] args)




        {
            //Func<int> GetRandom = delegate ()
            //{
            //    return new Random().Next(0, 200);
            //};

            //Console.WriteLine("10 random number:");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(GetRandom());
            //}

            ////To Bind with class new 
            ////Func<int, int, int, int> AddNumbers = DelegateDemo3.Add;
            ////old
            //Func<int, int, int, int> AddNumbers = new Func<int, int, int, int>(Add);

            //int sum = AddNumbers(30, 40, 50);
            //Console.WriteLine("Result:" + sum);

            ////Action<int> Add = delegate (int i)
            ////{
            ////    Console.WriteLine($"{i}");
            ////};
            ////Add(20, 30, 40);


            ////Action Method
            //Action<int, int, int> AddNumbers = DelegateDemo3.Add;
            //AddNumbers(30, 40, 50);

            ////Action<int> square = (int n) => { Console.WriteLine($"Square of {n} is {n * n}"); };
            //Action<int> square = n =>  Console.WriteLine($"Square of {n} is {n * n}");
            ////Action<int,int> square = (n) => Console.WriteLine($"Square of {n} is {n * n}");
            ////square(5, 5);
            //square(5);

            //Predicate 
            Predicate<string>isLower=str => str.Equals(str.ToLower());

            Console.WriteLine(isLower("cdac123"));
            Console.WriteLine(isLower("Cac123"));
            Console.WriteLine(isLower("cdac!!!"));


        }
    }
}
