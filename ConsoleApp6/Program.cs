using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {


        static void Main()
        {
            var myInt = new[] { 20, 4, 16, 9, 2 };  // Create an array of ints.

            Console.WriteLine("Before sort");
            foreach (var i in myInt)                // Print them out (before sort).
                Console.Write("{0} ", i);
            Console.WriteLine(Environment.NewLine + "----------------");

            Array.Sort(myInt);                      // Sort elements by magnitude.

            Console.WriteLine("After sorted");
            foreach (var i in myInt)                // Print them out (after sorted).
                Console.Write("{0} ", i);
            Console.WriteLine(Environment.NewLine + "----------------");
        }
    }
}

