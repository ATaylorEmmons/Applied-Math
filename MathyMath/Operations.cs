using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedMath
{
    static class Operations
    {

        public delegate uint SummationFunction(int n);

        //Todo: Variable size integer
        public static UInt64 Factorial(uint n)
        {
            if (n > 20)
            {
                throw new OverflowException("Max factorial for type Uint64 is 20.");
            }
            uint iteration = n;
            UInt64 ret = 1;

            while (iteration > 0)
            {
                ret *= iteration;
                iteration--;
            }

            return ret;
        }


        public static UInt64 Summation(SummationFunction f, int start, int end)
        {
            uint ret = 0;
            for (int index = start; index <= end; index++)
            {
                ret += f(index);
            }

            return ret;
        }


        public static UInt64 Choose(uint n, uint k)
        {
            if(n < k)
            {
                return 1;
            }
            return (Operations.Factorial(n)) / (Operations.Factorial(k) * Operations.Factorial(n - k));
        }
    }

}

