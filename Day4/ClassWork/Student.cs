using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    /*
     * 1- method
     * 2-costructor- faild if we want to modified it again and again
     * 3- By Making data field public,incorrect way public int _RollNo;
     * 
     * to overcome it we use Properties
     */
    internal class Student
    {
        public int _RollNo;
        //int _RollNo;
        //string _Name;
        //int _Age;
       /* public void SetRoll(int roll)
        {
            this._RollNo = roll;   
        }
        public int GetRoll()
        {
            return this._RollNo;
            
        }
        */

    }
    class StudentMain
    {
        static void Main(string[] args)
       {
        Student obj = new Student();
       obj._RollNo = 2000;
       Console.WriteLine(obj._RollNo);

    }
}
    }

