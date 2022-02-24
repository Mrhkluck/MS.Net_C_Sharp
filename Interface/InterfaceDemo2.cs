using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Interface
{
    interface ICalc3
    {
        
        int Add(int x, int y);//public and abstract here public is implicite there no need to write otherwise it will give error
        int Substract(int x, int y);
    }
    //Intrface inheritance
    interface ICalc4
    {

        //int Add(int x, int y); //public and abstract
        int Substract(int x, int y);


        //Multiple Inheritance like implementation
        //class Calculator : ICalc1, ICalc2
    }
       class Calculator2 : ICalc3,ICalc4
       {
        //atleast one copy of the Implementation 
        //Explicit Interface method Implementation
        public int Add(int x, int y)
        {
            return x + y;
        }

         //Explicit Interface method Implementation
        int ICalc3.Substract(int x, int y)
        {
            return x - y;
        }




        int ICalc4.Substract(int x, int y)
        {
                return x+~y+1;
        }
    
}
    internal class InterfaceDemo2
    {
        static void Main(string[] args)
        {
            Calculator2 calc2 = new Calculator2();
            Console.WriteLine("Sum:" + calc2.Add(20, 40));

            //Console.WriteLine("difference:"+calc2.Subtract(40,20));//invalid
            ICalc3 icalc3 = calc2;
            Console.WriteLine("Difference:"+icalc3.Substract(50,20));


            ICalc4 icalc4 = calc2;
            Console.WriteLine("Difference:" + icalc4.Substract(50, 20));
        }

        
    }
}
