using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_generics
{
    class GENerics
    {
        public static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3, 4, 5, 5234 };
            //UC6_generics<int> generics = new UC6_generics<int>[intarray];
            UC6_generics<int>.MAx();

        }

    }
}