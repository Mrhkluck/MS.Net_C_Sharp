using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Abstract class And  Abstract Method
namespace ConsoleDemoApp.Inheritance
{
    //public abstract class Shape
    abstract class Shape
    {
       //public  abstract int Area(int l, int b);
        internal abstract int Area(int l, int b);
        public void Display()
        {

        }
    }
    //public  class Rectangle : Shape
    class Rectangle : Shape
    {
        //public override int Area(int l, int b)
        internal override int Area(int l, int b)
        {
            return l * b;

        }
    }

    //Sealed Class
   //sealed class Triangle : Shape
    class Triangle : Shape
    {
        sealed internal override int Area(int l, int b)
        {
            return (l * b)/2;

        }
    }
    class MyTriangle : Triangle
    {
        //internal override int Area(int l, int b)
        //{
        //    return (l * b) / 2;

        //}
    }

    //internal class InheritanceDemo4  : Triangle because it is sealed class

    internal class InheritanceDemo4 

    {
        static void Main(string[] args)
        {
            
            
                Shape shape = new Rectangle();
                Console.WriteLine(shape.Area(30,20));

                shape = new Triangle();
                Console.WriteLine(shape.Area(30,50));
            

        }
    }
}
