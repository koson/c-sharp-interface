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


        class MyClass : IIfc1
        {
            public void PrintOut(string s)
            {
                Console.WriteLine("Calling through: {0}", s);
            }
        }

        static void Main()
        {
            MyClass mc = new MyClass(); // Create class object.
            mc.PrintOut("object"); // Call class object implementation method.

            IIfc1 ifc = mc as IIfc1; // Acts like cast: (IIfc1)mc.
            ifc.PrintOut("interface"); // Call interface method.
        }

    }

}

