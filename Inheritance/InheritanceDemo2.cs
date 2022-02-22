using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Inheritance
{
    class MyBase2
    {
        public virtual  void Display()
        {
            Console.WriteLine("Display from myBase");
        }
    }
    class MyDerive2: MyBase2
    {
        //Method overriding
        //runtime polymorphism
        //if we use new it automatically it call method hiding

        public override void Display()
        {
            Console.WriteLine("Display from My Derive-2");
            
        }

    }
    internal class InheritanceDemo2
    {
        static void Main(string[] args)
        {
            MyDerive2 derive2 = new MyDerive2();
            derive2.Display();

            MyBase2 myBase2 = derive2;
            myBase2.Display();
        }
        
    }
}
