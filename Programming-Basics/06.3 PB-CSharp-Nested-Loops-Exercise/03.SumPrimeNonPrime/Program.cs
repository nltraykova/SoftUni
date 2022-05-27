using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int num;

            int sumPrimeNums = 0;
            int sumNonPrimeNums = 0;

            while (input != "stop")
            {
                num = int.Parse(input);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i < num-1; i++) 
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrimeNums += num;
                }
                else
                {
                    sumNonPrimeNums += num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNums}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNums}");

        }
    }
}
