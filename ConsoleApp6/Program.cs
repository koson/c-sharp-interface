using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        class MyClass
        {
            public int TheValue;
        }

        static void Main()
        {
            MyClass[] mc = new MyClass[5];
            for (int i = 0; i < 5; i++)
            {
                mc[i] = new MyClass();
            }

            mc[0].TheValue = 20;
            mc[1].TheValue = 4;
            mc[2].TheValue = 16;
            mc[3].TheValue = 9;
            mc[4].TheValue = 2;

            foreach (var m in mc) // Print them out.
                Console.Write("{0} ", m.TheValue);
            Console.WriteLine(Environment.NewLine + "------------------");
        }
    }
}

