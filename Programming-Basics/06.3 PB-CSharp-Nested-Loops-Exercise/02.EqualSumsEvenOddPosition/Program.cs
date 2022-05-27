using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            int evenSum;
            int oddSum;
            
            for (int i = firstNum; i <= lastNum; i++)
            {
                string currentNum = i.ToString();

                evenSum = 0;
                oddSum = 0; 

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}
