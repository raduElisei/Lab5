using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public static class Fibonacci
    {
        // TODO: complete the method
        private static uint[] Generate(int n)
        {
            uint[] previousSequence = Generate(n - 1);
            uint[] newSequence =  new uint[n];
            Array.Copy(previousSequence, newSequence, n);
            newSequence[n - 1] = previousSequence[n - 2] + previousSequence[n - 3];

            return newSequence;
        }

        public static uint[] GenerateFib(int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException("n", "Chosen n is out of range");
            }
            else if (n == 1)
            {
                return new uint[1] { 0 };
            }
            else if (n == 2)
            {
                return new uint[2] { 0, 1 };
            }
            else
            {
                return Generate(n);
            }
        }
    }
}
