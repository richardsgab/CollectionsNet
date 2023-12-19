using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int begin = 50;
            int end = 150;

            Filter.FilterByTen(begin, end);
            Console.WriteLine();
            Filter.FilterByOthers(begin, end);
        }
    }
}
