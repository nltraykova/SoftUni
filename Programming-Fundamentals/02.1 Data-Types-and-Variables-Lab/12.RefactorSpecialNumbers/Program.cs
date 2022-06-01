using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int currentDigit = i;
                int sum = 0;
                
                while (currentDigit > 0)
                {
                    sum += currentDigit % 10;
                    currentDigit = currentDigit / 10;
                }
                
                bool isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
            }

        }
    }
}
