using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGenerics
{
    class Calculator
    {
        public static bool Areequal<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = Calculator.Areequal<int>(1, 2);
            if (result) 
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

        }
    }
}
