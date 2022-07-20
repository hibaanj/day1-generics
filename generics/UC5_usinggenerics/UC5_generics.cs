using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5_usinggenerics
{
    internal class UC5_generics<t> where t : IComparable 
    {
        public static t val;

        public static t MAx (t st1, t st2, t st3)
        {
            if (st1.CompareTo(st2) > 0 && (st1.CompareTo(st2)) > 0 ||
                (st1.CompareTo(st2)) >= 0 && (st1.CompareTo(st2)) > 0 ||
                (st1.CompareTo(st2)) > 0 && (st1.CompareTo(st2)) >= 0)
                {
                    //return val = st1;
                    Console.WriteLine(st1);
                }


            else if ((st2.CompareTo(st1)) > 0 && (st2.CompareTo(st3)) > 0 ||
                (st2.CompareTo(st1)) >= 0 && (st2.CompareTo(st3)) > 0 ||
                (st2.CompareTo(st1)) > 0 && (st2.CompareTo(st3)) >= 0)
                {
                    //return val = st2;
                    Console.WriteLine(st2);

                }
                

            else if ((st3.CompareTo(st1)) > 0 && (st3.CompareTo(st2)) > 0 ||
                (st3.CompareTo(st1)) >= 0 && (st3.CompareTo(st2)) > 0 ||
                (st3.CompareTo(st1)) > 0 && (st3.CompareTo(st2)) >= 0)
                {
                    //return val = st3;
                    Console.WriteLine(st3);
                }
            return val;
        }
        
    }
}
