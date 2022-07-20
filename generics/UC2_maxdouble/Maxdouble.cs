using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_maxdouble
{
    internal class Maxdouble
    {
        
            public static void MaxDouble(double firstv, double secondv, double thiredv)
            {
                if ((firstv.CompareTo(secondv))>0 && (firstv.CompareTo(thiredv)>0))
                {
                    Console.WriteLine($"{firstv}is the greatest");
                }
                else if ((secondv.CompareTo(firstv))>0 && (secondv.CompareTo(thiredv)>0))
                {
                    Console.WriteLine($"{secondv}is the greatest");
                }
                else if ((thiredv.CompareTo(firstv)>0) && (thiredv.CompareTo(secondv)>0))
                {
                    Console.WriteLine($"{thiredv}is the greatest");
                }

            }

        
    }
}
