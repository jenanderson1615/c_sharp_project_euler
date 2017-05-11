using System;
using System.Collections.Generic;

namespace Even_Fib_Sum
{
    class Program
    {
        static int upperLimit = 4000000;
        static int firstNumber = 1;
        static int secondNumber = 2;
        static int totalOfNumbers = 2;
        
        static void Main(string[] args)
        {
            createFibNumberList();
            Console.WriteLine($"{totalOfNumbers}");
        }

        static void createFibNumberList()
        {
            int thirdNumber = firstNumber + secondNumber;
            while (thirdNumber < upperLimit)
            {
                if (thirdNumber % 2 == 0)
                {
                    totalOfNumbers += thirdNumber;
                }
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = firstNumber + secondNumber;
            }
        }
    }
}
