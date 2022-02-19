using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class Point
    {
        int x;
        int y;

        public Point()
        {
            this.x = 20;   
            this.y = 30;
        }
        public Point(int x=50,int y = 40)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"Point({x},{y})";
        }

        //overload + 0perator
        public static Point operator +(Point ob1, Point ob2)
        {
            int x=ob1.x+ob2.x;
            int y=ob1.y+ob2.y;
            return new Point(x,y);

            //new Point(ob1.x + ob2.x, ob1.y + ob2.y);

        }

        //overload - 0perator
        public static Point operator -(Point ob1, Point ob2)
        {
           return new Point(ob1.x - ob2.x, ob1.y - ob2.y);
        }

        //overload * 0perator
        public static Point operator *(Point ob1, Point ob2)
        {
            return new Point(ob1.x * ob2.x, ob1.y * ob2.y);
        }


        //Desturctor
        ~Point()
        {
            Console.WriteLine("Point destructor called");
        }

        class PointMain
        {
            static void Main(string[] args)
            {
                Point p1 = new Point();
                Console.WriteLine(p1);

                Point p2 = new Point(40,30);
                Console.WriteLine(p2);

                Point p3 = new Point(70);
                Console.WriteLine(p3);

                Point p4 = new Point(y:60);
                Console.WriteLine(p4);

                Point p5 = new Point(y:80,x:20);
                Console.WriteLine(p5);

                Point p9 = p1;
                //Point p6=p1+p2;//here two object p1 and p2 are object.
                // object can't do arthematric operation solution - operator overloading
                //those operator whose behaviour is not defined for the referance
                //Point p7=p1-p2;
                //Point p8= p1*p2;

                Point p6 = p1 + p2;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
                Console.WriteLine(p6);

                //GC.Collect(0);

                Console.WriteLine(p1-p2);
                Console.WriteLine(p1*p2);
            }
        }
    }

}
