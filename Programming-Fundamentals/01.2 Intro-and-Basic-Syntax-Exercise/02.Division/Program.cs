using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int biggerDivision = 0;

            if (num % 2 == 0)
            {
                biggerDivision = 2;
            }

            if (num % 3 == 0)
            {
                biggerDivision = 3;
            }

            if (num % 6 == 0)
            {
                biggerDivision = 6;
            }

            if (num % 7 == 0)
            {
                biggerDivision = 7;
            }

            if (num % 10 == 0)
            {
                biggerDivision = 10;
            }

            if (biggerDivision != 0)
            {
                Console.WriteLine($"The number is divisible by {biggerDivision}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
