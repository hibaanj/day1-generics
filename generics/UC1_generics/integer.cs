using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_generics
{
    internal class integer
    {
        public static void MaxInt(int firstv, int secondv, int thiredv)
        {
            if((firstv > secondv)  && (firstv > thiredv))
            {
                Console.WriteLine($"{firstv}is the greatest");
            } 
            else if((secondv > firstv) && (secondv > thiredv))
            {
                Console.WriteLine($"{secondv}is the greatest");
            }
            else if ((thiredv > firstv) && (thiredv > secondv))
            {
                Console.WriteLine($"{thiredv}is the greatest" );
            } 

        }
        
    }
}
