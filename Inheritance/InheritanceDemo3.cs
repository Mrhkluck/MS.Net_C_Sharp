using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Constructor/Destructor in Inheritance
namespace ConsoleDemoApp.Inheritance
{
    class MyBase3
    {

        int id;
        public MyBase3(int id) //public MyBase3()
        {
            this.id = id;
            //Console.WriteLine("Default Constr from MyBase");
            Console.WriteLine($"Constr from MyBase,ID:{this.id }");
        }
        //static MyBase3()
        //{
        //    Console.WriteLine("Static Contr from MyBase");
        //}
        //~MyBase3()
        //{
        //    Console.WriteLine("Destructor from MyBase");
        //}
        public void Display()
        {
            Console.WriteLine("Display from MyBase-3");
        }

    }

    class Derive1 : MyBase3
    {
        //public Derive1() : base() It will called default constructor of the base
        //cv   public Derive1() :base(1000)//forgivenif  user given then
        string name;
        public Derive1(int id,string name) : base(id)
        {
            //super() in java
            this.name = name;
            //Console.WriteLine("Default Constr from Derive1");
            Console.WriteLine($"Constr from Derive1 , Name:{this.name}");

           this.Display(); //calling of current class display method
           base.Display(); //calling of base classdisplay method
        }
        //static Derive1()
        //{
        //    Console.WriteLine("Static Contr from Derive1");
        //}
        //~Derive1()
        //{
        //    Console.WriteLine("Destructor from Derive1");
        //}
        public void Display()
        {
            Console.WriteLine("Display from Derive-1");
        }
    }

    //Multiple Inheritance
    class Derive2 : Derive1
    {
        //public Derive2()
        //public Derive2():base(100,"rashid") fixed value
        float salary;
        public Derive2(int id,string name,float salary) : base(id,name)// for dyname output
        {
            this.salary = salary;
            //Console.WriteLine("Default Constr from Derive2");
            Console.WriteLine($"Constr from Derive2,Salary:{this.salary}");

            this.Display();
            base.Display();// here it will call derive1 because for it base is derive 1
        }
        
        //static Derive2()
        //{
        //    Console.WriteLine("Static Contr from Derive2");
        //}
        //~Derive2()
        //{
        //    Console.WriteLine("Destructor from Derive2");
        //}
        public void Display()
        {
            Console.WriteLine("Display from Derive-2");
        }
    }

    internal class InheritanceDemo3
    {
        static void Main(string[] args)
        {
            //Derive1 derive = new Derive1();
           // MyBase3 ob= new MyBase3();
            //Derive2 derive2 = new Derive2();
            Derive2 derive2 = new Derive2(1000,"Rashid",3450000.0f);
        }
    }
}

