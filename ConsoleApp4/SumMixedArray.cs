using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class KataSumMix
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;

            foreach (object element in x)
            {
                sum += Convert.ToInt32(element);
            }

            return sum;
        }
    }
}
