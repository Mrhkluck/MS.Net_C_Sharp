using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Interface
{
    interface ICalc1
    {
        //int id;
        int Add(int x, int y);//public and abstract here public is implicite there no need to write otherwise it will give error
        int Substract(int x, int y);
        //public void show(){
        //}
    }
    //Intrface inheritance
    interface ICalc2:ICalc1
    {

        new int Substract(int x, int y); //public and abstract
        //int Add(int x, int y);
    }

    //Multiple Inheritance like implementation
    //class Calculator : ICalc1, ICalc2
     class Calculator : ICalc2
    { 
        //atleast one copy of the Implementation 
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }
    }
    internal class InterfaceDemo1
    {
        static void Main(string[] args)
        {
            //Class object referance
            Calculator calc = new Calculator();
            Console.WriteLine("sum:"+calc.Add(30,20));
            Console.WriteLine("Difference:"+calc.Substract(50,20));
            //create Interface and run time binding we need inerface and we are calling interface reference
            ICalc1 icalc1 = calc;
            Console.WriteLine("Sum:"+icalc1.Add(40,30));
            Console.WriteLine("Difference:" + icalc1.Substract(100, 30));

            ICalc2 icalc2 = calc;
            Console.WriteLine("Difference:"+icalc2.Substract(100,30));
           // Console.WriteLine("Sum:" + icalc1.Add(40, 30));
        }
    }
}
