using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_string
{
    class MaxDouble
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("testcase-1- returns first element since its the greatest");
            MaxString.Stirng("zebra", "peach", "banana");
            Console.WriteLine(" ");

            Console.WriteLine("testcase-2- returns second element since its the greatest");
            MaxString.Stirng("apple", "peach", "banana");
            Console.WriteLine(" ");


            Console.WriteLine("testcase-3- returns third element since its the greatest");
            MaxString.Stirng("apple","peach","zzzeza");

            
        }

    }
}