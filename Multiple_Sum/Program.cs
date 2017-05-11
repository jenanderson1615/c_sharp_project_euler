using System;
using System.Collections.Generic;

namespace Multiple_Sum
{
    class Program
    {
        static int upperLimit = 1000;
        static int total = 0;

		static void Main(string[] args)
		{
            calculatePrimeTotal();
			Console.WriteLine($"The total of the primes is: {total}");
		}

        static void calculatePrimeTotal()
        {
            for (int i = 1; i < upperLimit; i++)
            {
                if (i % 3 == 0)
                {
                    total += i;
                    continue;
                }
                if (i % 5 == 0)
                {
                    total += i;
                    continue;
                }
            }
        }
	}
}

