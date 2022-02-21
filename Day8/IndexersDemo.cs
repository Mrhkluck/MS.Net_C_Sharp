using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day8
{
    class Employee
    {
        long[] MobileNo;
        public Employee(int size = 5)
        {
            MobileNo = new long[size];
        }

        //to define indexer
        //Indexer to Read/Write MobileNo Array Value
        public long this[int i]
        {
            get { return MobileNo[i]; }
            set { MobileNo[i] = value; }


        }

        //public long this[int row, int col]
        //{
        //    get { return MobileNo[(int)row, (int)col]; }
        //    set { MobileNo[(int)row = value, (int)(col)] = value; }
        //}

        //Property to return MobileNo array Length
        public int ArrayLength
        {
            get => MobileNo.Length;
        }
        public void DisplayMobileNos()
        {
            Console.WriteLine("Mobile nos. are");
            foreach (var item in MobileNo)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class IndexersDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[0] = 8908324940;//Indexer set accessor will be called
            emp[4] = 9876543210;
            Console.WriteLine(emp[0]);// Indexer get accessor will be called

            emp.DisplayMobileNos();

            Console.WriteLine("Read all data using indexer");
            int len=emp.ArrayLength;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(emp[i]);  
            }
        }
    }
}
