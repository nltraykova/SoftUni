using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int evenSum =  GetSumOfEvenDigits(input);

            int oddSum = GetSumOfOddDigits(input);

            int multiplySumEvenSumOdd = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(multiplySumEvenSumOdd);
        }

        static int GetSumOfEvenDigits(int input)
        {
            int evenSum = 0;
            int digits = Math.Abs(input);

            while (digits > 0)
            {
                int currDigit = digits % 10;

                if (currDigit % 2 == 0)
                {
                    evenSum += currDigit;
                }

                digits = digits / 10;
            }
            
            return evenSum;
        }

        static int GetSumOfOddDigits(int input)
        {
            int oddSum = 0;
            int digits = Math.Abs(input);

            while (digits > 0)
            {
                int currDigit = digits % 10;

                if (currDigit % 2 != 0)
                {
                    oddSum += currDigit;
                }

                digits = digits / 10;
            }

            return oddSum;
        }
        
        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int result = evenSum * oddSum;

            return result;
        }


    }
}
