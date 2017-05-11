using System;
using System.Collections.Generic;

namespace Multiple_Sum
{
    class Program
    {
        static int upperLimit = 1000;

		static void Main(string[] args)
		{
           List<int> myList = createMultiplesList();
            printMultiplesList(myList);
            int primeTotal = calculatePrimeTotal();
			Console.WriteLine($"The total of the primes is: {primeTotal}");
		}

		static int calculatePrimeTotal()
		{
			int primeTotal = 0;
			return primeTotal;
		}

		//
		// Loop through all the values up to upper limit and add to an array if N % 3 or N % 5 is 0
        //
        static List<int> createMultiplesList()
        {
           List<int> someInts = new List<int>(); ;
            for (int i = 1; i < upperLimit; i++)
            {
                if (i % 3 == 0)
                {
                    someInts.Add(i);
                    continue;
                }
                if (i % 5 == 0)
                {
                    someInts.Add(i);
                    continue;
                }
            }
            return someInts;
        }

        static void printMultiplesList(List<int> myList)
		{
            foreach (int item in myList)
			{
                Console.WriteLine($"{item}");
			}
		}
	}
}

