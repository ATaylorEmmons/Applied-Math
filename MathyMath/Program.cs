using AppliedMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UInt32> factors = NumberTheory.Factors(12);
            foreach(uint factor in factors)
            {
                Console.WriteLine(factor);
            }
            Console.ReadLine();
        }
    }
}
