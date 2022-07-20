using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_maxdouble
{
    class MaxDouble
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("testcase-1- returns first element since its the greatest");
            Maxdouble.MaxDouble(14.70, 9.4,3.7);
            Console.WriteLine(" ");
            
            Console.WriteLine("testcase-2- returns second element since its the greatest");

            Maxdouble.MaxDouble(12.5, 34.2, 7.8);
            Console.WriteLine(" ");

           
            Console.WriteLine("testcase-3- returns third element since its the greatest");
            Maxdouble.MaxDouble(1.4, 3.5, 99.99);
        }

    }
}