using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        class MyClass : IComparable
        {
            public int TheValue;

            public int CompareTo(object obj)
            {
                MyClass mc = (MyClass)obj;
                if (this.TheValue < mc.TheValue) return -1;
                if (this.TheValue > mc.TheValue) return 1;
                return 0;
            }
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

            Console.WriteLine("Before");
            foreach (var m in mc) // Print them out.
                Console.Write("{0} ", m.TheValue);
            Console.WriteLine(Environment.NewLine + "------------------");

            Array.Sort(mc);

            Console.WriteLine("After");
            foreach (var m in mc) // Print them out.
                Console.Write("{0} ", m.TheValue);
            Console.WriteLine(Environment.NewLine + "------------------");
        }

    }

}

