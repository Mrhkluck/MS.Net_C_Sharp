//using System; system is root just like java
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using aliases
using MyConsole = System.Console;
using MConsole = ConsoleDemoApp.NameSpaces.Console; //path of console line no.25

namespace ConsoleDemoApp.NameSpaces
{
    internal class NameSpaceDemo
    {
        static void Main(string[] args0){ 


            //Console.WriteLine("dsadshjfsjfhjshdd");// using statement
            System.Console.WriteLine("dfhjd"); //full qualified

            MyConsole.WriteLine("dshffgsdhdfg"); //nick name using alias
            Console obj = new Console();
            obj.Print();

            MConsole obj2 = new MConsole();
        }
    }
    class Console
    {
        public void Print()
        {
            System.Console.WriteLine("dfhjd");

            MyConsole.WriteLine("dshffgsdhdfg");
        }
    }
}
