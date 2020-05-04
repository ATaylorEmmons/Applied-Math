using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathyMath
{
    static class NumberTheory
    {
        public static UInt64 Fibonacci(uint n)
        {
            UInt64 n_1 = 2;
            UInt64 n_2 = 3;
            UInt64 ret = 0;

            if(n <= 2)
            {
                if(n == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }

            }

            for(uint index = 2; index < n; index++)
            {

                ret = n_1 + n_2;
                n_1 = n_2;
                n_2 = ret;

            }

            return ret;
        }

        public static List<UInt32> Factors(uint n)
        {
            List<UInt32> factors = new List<UInt32>();

            uint currentDivisor = 2;

            uint stop = (uint)Math.Sqrt(n) + 1;

            while(currentDivisor < stop)
            {
                if(n % currentDivisor == 0)
                {
                    factors.Add(currentDivisor);
                    factors.Add(n / currentDivisor);
                }
                currentDivisor++;
            }

            return factors;
        }
    }
}
