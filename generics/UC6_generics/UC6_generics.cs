using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_generics
{
    internal class UC6_generics<t> where t : IComparable
    {
        
            public static t val;

        public static t MAx(params int[] intarray )
        {
            int sum = 0;
            foreach (int elements in intarray)
            {
                
                sum += elements;

                

            }
            Console.WriteLine(sum);


            return val ;
        }
        

        
    }
}
