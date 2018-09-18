﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        interface IIfc1 // Declare interface.
        {
            void PrintOut(string s);
        }
        interface IIfc2 // Declare interface
        {
            void PrintOut(string s);
        }
        class MyClass : IIfc1, IIfc2 // Declare class.
        {
            public void PrintOut(string s)
            {
                Console.WriteLine("Calling through: {0}", s);
            }
        }


        static void Main()
        {
            MyClass mc = new MyClass();
            IIfc1 ifc1 = (IIfc1)mc; // Get ref to IIfc1.
            IIfc2 ifc2 = (IIfc2)mc; // Get ref to IIfc2.

            mc.PrintOut("object"); // Call through class object.
            ifc1.PrintOut("interface 1"); // Call through IIfc1.
            ifc2.PrintOut("interface 2"); // Call through IIfc2.
        }

    }

}

