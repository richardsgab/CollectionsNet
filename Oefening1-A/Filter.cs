using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1_A
{
    internal class Filter
    {

        public static void FilterByTen(int begin, int end)
        {
            List<int> divisibleBy10 = new List<int>();
            for (int i = begin; i <= end; i++)
            {
                if (i % 10 == 0)
                {
                    divisibleBy10.Add(i);
                }
            }

            foreach (int i in divisibleBy10)
            {
                Console.WriteLine(i);
            }
        }
        public static void FilterByOthers(int begin, int end)
        {
            List<int> divisibleBy3And5 = new List<int>();
            for (int i = begin; i <= end; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    divisibleBy3And5.Add(i);
                }
            }

            foreach (int i in divisibleBy3And5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
