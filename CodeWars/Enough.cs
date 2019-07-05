using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class EnoughKata
    {
        public static int Enough(int cap, int on, int wait)
        {
            int overflow = on + wait - cap;

            if (overflow <= 0)
            {
                return 0;
            }
            else return overflow;
        }
    }
}
