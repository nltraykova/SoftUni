using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int num = inputNum;
            int sum = 0;

            while (num > 0)
            {
                int currNum = num % 10;
                int currNumfactorial = 1;

                for (int i = 2; i <= currNum; i++)
                {
                    currNumfactorial *= i;
                }

                sum += currNumfactorial;

                num = num / 10;
            }

            if (sum == inputNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
