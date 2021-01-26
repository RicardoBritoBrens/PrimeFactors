using System.Collections.Generic;

namespace PrimeFactorsTest
{
    public static class PrimeFactors
    {
        public static List<int> Generate(int n)
        {
            List<int> primes = new List<int>();
            int candidate = 2;
            while (n > 1)
            {
                while (n % candidate == 0)
                {
                    primes.Add(candidate);
                    n /= candidate;
                }
                candidate++;
            }

            return primes;
        }
    }
}