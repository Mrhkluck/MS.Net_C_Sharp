using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class Employee
    {
        int _IdNo; //_ optional, non static, object dependented
        string Name;//non static 
        static int id; //static data field, object independent


        public Employee()
        {
            Console.WriteLine("Default Constructor");
            //this._IdNo = 1000;
            this._IdNo = id++;
            this.Name = "admin";
        }

        //Paramatarize Construct
        public Employee(int _IdNo)
        {
            Console.WriteLine("Parametrized construtor for IdNo");
            this._IdNo = _IdNo;
            id = _IdNo+1;//updating ststic id with user value

        }

        public Employee(string Name)
        {
            Console.WriteLine("Parametrized construtor for Name");
            this.Name = Name;
            this._IdNo=id++;//to assign  id and modified, default id-1000by static cons,1001 increment

        }
        public Employee(int _IdNo,string Name)//5000
        {
            Console.WriteLine("Parametrized construtor for Name and Id");
            this.Name = Name;
            this._IdNo = _IdNo;
            id= _IdNo+1;//updating ststic id with user value

        }
        //static Constructor
        static Employee()
        {
            Console.WriteLine("Static constr called");
            Console.WriteLine("It's used to Initialize the class static data field");
            id = 1000;//intial 
        }

        public Employee setEmpData(int IdNo,string Name)
        {
            this._IdNo = IdNo;
            this.Name = Name;
            Console.WriteLine("Employee detail saved");
            return this;

        }
        public void DisplayEmpData()
        {
            Console.WriteLine($"Id:{_IdNo}\tName:{Name}");

        }
        public override string ToString()
        {
            return $"id:{_IdNo}\tname:{Name}";
        }
    }
    class EmployeeMain
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Console.WriteLine(emp1);

            Employee emp2 = new Employee();
            Console.WriteLine(emp2);

            Employee emp3 = new Employee(10000);
            Console.WriteLine(emp3);

            Employee emp4 = new Employee();
            Console.WriteLine(emp4);


            /* Employee emp2 = new Employee(1000);
             Console.WriteLine(emp2);
             Employee emp3 = new Employee("Rashid");
             Console.WriteLine(emp3);
             Employee emp4 = new Employee();
             Console.WriteLine(emp4);  */

            /*Employee employee1 = new Employee();//Object Creation
            employee1.DisplayEmpData();//0,null

            Employee employee2 = new Employee();//Objest Creation
            employee2.setEmpData(1000, "Brown Munda");

            Console.WriteLine(employee2);//address but we gave value because of tostring overwrite
            // If tostring will not writen then we will get type of the empployee2
            //1000,Brown Munde

            Employee employee3 = employee2;

            employee3.setEmpData(2000, "Mrhk");

            Console.WriteLine(employee3);//2000,Mrhk
            Console.WriteLine(employee2);//2000,Mrhk

            Console.WriteLine(employee3.GetHashCode());
            Console.WriteLine(employee2.GetHashCode());

            //2nd method to create object
            new Employee().setEmpData(3000, "MrhkAno");// it set but get object pass
                                       //because no refernce will be saved so we used class instnce
            new Employee().DisplayEmpData();


            //Employee emp = new(); //c# 9 and above

           // List<int> list = new List<int>();*/
        }
    }
}
