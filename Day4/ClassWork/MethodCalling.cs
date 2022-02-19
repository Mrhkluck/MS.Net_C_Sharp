using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class MethodCalling
    {
        static void Call_By(int x,int y)
        {
            x = x + 30;
            y = y + 40;
            Console.WriteLine($"x:{x}\ty:{y}");//50,80
        }

        static void Call_By_Refrence(ref int x, ref int y) //*x,*y
        {
            x = x + 30;
            y = y + 40;
            Console.WriteLine($"x:{x}\ty:{y}");//50,80
        }

        // static void Call_By_OutputParameter(int x, int y,ref int sum,ref int diff)
        static void Call_By_OutputParameter(int x, int y, out int sum, out int diff)
        {
            sum = x + y;
            diff= x- y; 
           
        }

                                                                    //default argument/optional argument
                                                                    //this prevent overloading
        static void Call_By_Named_Default(string fname, string lname="Humayun",float salary=25000)
        {
            Console.WriteLine($"Welcome:{fname}{lname}");
            Console.WriteLine($"Your Salary:{salary}");
        }

        //Params argument
        static int SumValues(int id,params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;

            }
            return sum;
        }
        static void Main(string[] args)
        {
            /*   //int a, b;
              // Console.WriteLine($"a:{a}\tb:{b}"); because it is unassign so error
              int a=20,b=40;
               Console.WriteLine($"a:{a}\tb:{b}");//20,40
               //MethodCalling.Call_By(a, b);//Static method call
               Console.WriteLine("=============");
               Call_By_Refrence(ref a, ref b);//&a,&b
               Console.WriteLine($"a:{a}\tb:{b}");//50,80
            */
            //int a = 30, b = 20, s=0, differnce=0;
            //Call_By_OutputParameter(a,b,ref s, ref differnce);

            //int a = 30, b = 20, s, differnce;//may be initial or not
            //Call_By_OutputParameter(a, b,out s,out differnce);
            //Console.WriteLine($"Sum:{s}\tDifference:{differnce}");


            /*Call_By_Named_Default("Rashid","Humayun",245000);//valid
            Call_By_Named_Default(lname:"Humayun", fname:"Rashid",salary:245000);
            // Call_By_("Humayun", "Rashid", 245000);//valid but invalid result // fail
            // To make it right we need overloading 
            Call_By_Named_Default(salary:245000,fname:"Rashid",lname:"Humayun");//invalid
            Call_By_Named_Default("Rashid","Humayun");//invalid // salary=25000

            Call_By_Named_Default("Manish", salary: 35400);*/

            int res = SumValues(10,new[] { 1, 2, 3, 4, 5 });//15
            Console.WriteLine("result:"+res);

             res = SumValues(1, 2, 3, 4, 5,6 );//20
            Console.WriteLine("result:" + res);

            res = SumValues(1, 2, 3, 4);//9
            Console.WriteLine("result:" + res);

            res = SumValues(1, 2);//2
            Console.WriteLine("result:" + res);


            //createArray(type,params int[]arr)
            //create(integer10)
            //create(float,3,4)
            //create(long,3,4,5)
        
        }
    }
}
