using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.DelegateDemo
{
    //Delegate defination
    public delegate int MyDelegate(int x, int y);
   // public delegate void MyDelegate(int x, int y);

    class Test1
    {
        //public void Add(int a , int b)
            public int Add(int a, int b)
        {
            //Console.WriteLine($"Sum is:{a+b}");
            return a + b;
        }
        //public  static void Subtract(int a, int b)
             public static int Subtract(int a, int b)
        {
           // Console.WriteLine($"Difference is:{a - b}");
           return a - b;
        }
    }
    class Test2
    {
        //public void Multiply(int a, int b)
            public int Multiply(int a, int b)
        {
            //Console.WriteLine($"Multiply is:{a * b}");
            return a* b;    
        }
       // public static void Divide(int a, int b)
             public static int Divide(int a, int b)
        {
            //Console.WriteLine($"Division is:{a / b}");
            return a / b;
        }
    }
    internal class DelegateDemo1
    {
        static void Main(string[] args)
        {
            //Instantiation
           // MyDelegate myDelegate= new MyDelegate(Test1.Subtract(50,90)); it will call method not method reference
            //MyDelegate myDelegate = new MyDelegate(Test1.Subtract); 

            //Invocation
           // myDelegate(50, 20);

            //Test1 t1 = new Test1();
            //MyDelegate myDelegate = new MyDelegate(t1.Add);

            MyDelegate myDelegate = new MyDelegate(new Test1().Add);//cs hod . instance method - obj reference
            int res;
             res = myDelegate.Invoke(50, 40);
            Console.WriteLine("Result :"+res);
            myDelegate += Test1.Subtract;//It hod. it is static //syntex to bind multiple method
            //res = myDelegate.Invoke(500, 40);
            //Console.WriteLine("Result :" + res);
            myDelegate += Test2.Divide;//civil hod . it is static

            Test2 t2 = new Test2();

            myDelegate += new Test2().Multiply;//instance method - obj reference


            // myDelegate(50, 20);
            //myDelegate.Invoke(50,20);
            res = myDelegate.Invoke(50, 20);
            Console.WriteLine("result:"+res);

            myDelegate -= t2.Multiply;
            res=myDelegate.Invoke(50, 30);
            Console.WriteLine("result:"+res);



        }
    }
}
