using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIRST WAY
            
            //int input = int.Parse(Console.ReadLine());
            //int sum = 0;

            //while (input != 0)
            //{
            //    int lastDigit = input % 10;
            //    sum += lastDigit;
            //    input /= 10;
            //}

            //Console.WriteLine(sum);

            
            //SECOND WAY

            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            Console.WriteLine(sum);
        }


    }
}
