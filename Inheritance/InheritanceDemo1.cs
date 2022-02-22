using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Inheritance
{
    class MyBase
    {
        //public void Display()
        //{
        //    Console.WriteLine("Display from MyBase");

        //}

        //protected void Display()
        //{
        //    Console.WriteLine("Display from MyBase");

        //}
        //protected void Display()
        //{
        //    Console.WriteLine("Display from MyBase");

        //}
        //protected internal void Display()
        //{
        //    Console.WriteLine("Display from MyBase");

        //}
         internal void Display()
        {
            Console.WriteLine("Display from MyBase");

        }
    }

        class MyDerive1 : MyBase
        {
            public void Show()
            {
                Console.WriteLine("Show from My Derive-1");
                Display(); //protected menbers are accessible within child but not outside of class
            }


        //Method Hiding
        //Compile time polymorphism
        internal new void Display()
        {
            Console.WriteLine("Display from My Derive-1");
        }
        }


    
    internal class InheritanceDemo1
    {
        static void Main(string[] args)
        {
            MyDerive1 derive = new MyDerive1();
            derive.Display();
            //derive.Show();

            MyBase myBase = new MyBase();
            myBase.Display();
           // myBass.Show();  //invalid

            MyDerive1 derive2 = myBase as MyDerive1;//downcast or (MyDerive1)
            derive2.Display();


        }
    }
}
