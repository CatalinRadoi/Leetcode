using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class PowerOfThree
    {
        public bool IsPowerOfFour(int n)
        {
            if (n == 1)
            {
                return true;
            }

            if (n == 0)
            {
                return false;
            }

            while (n % 4 == 0)
            {
                n /= 4;
                if (n == 1)
                {
                    return true;
                }
            }

            return false;

        }
    }
}
