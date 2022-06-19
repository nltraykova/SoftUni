using System;

namespace _10._TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            TopNumber(num);

        }

        static void TopNumber(int num)
        {
                for (int i = 1; i <= num; i++)
                {
                    if (IsSumDivisibleByEight(i) && IsHoldAtLeastOneOddDigit(i))
                    {
                        Console.WriteLine(i);
                    }
                }
        }

        static bool IsHoldAtLeastOneOddDigit(int num)
        {
            while (num > 0)
            {
                int currDigit = num % 10;
                if (currDigit % 2 != 0)
                {
                    return true;
                }
                num = num / 10;
            }

            return false;
        }

        static bool IsSumDivisibleByEight(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int currDigit = num % 10;
                sum += currDigit;
                num = num / 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
