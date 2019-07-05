using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
        public class ReduceButGrowKata
    {
        public static int Grow(int[] x)
        {
            int result = 1;
            for ( int i = 0; i < x.Length; i++)
            {
                result = result * x[i];
            }
            return result;
        }
    }
}
