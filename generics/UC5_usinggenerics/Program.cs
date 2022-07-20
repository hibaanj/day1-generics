using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_usinggenerics
{
    class GENerics
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("testcase-1- returns greatest element using integer and same method");
            UC5_generics<int>.MAx(1111, 1111111, 111);

            Console.WriteLine("testcase-2-return greatest using double elements but same methods");
            UC5_generics<double>.MAx(2.5, 1.5, 77.2  );

            Console.WriteLine("testcase-3- returns greatest using string and same method");
            UC5_generics<string>.MAx("apple", "banana", "peach");

        }

    }
}