using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        interface IIfc1
        {
            void PrintOut(string s);
        }
        interface IIfc2
        {
            void PrintOut(string t);
        }


        class MyClass : IIfc1, IIfc2 // Implement both interfaces.
        {
            public void PrintOut(string s) // Single implementation for both
            {
                Console.WriteLine("Calling through: {0}", s);
            }
        }


        static void Main()
        {
            MyClass mc = new MyClass();
            mc.PrintOut("object");

        }

    }

}

