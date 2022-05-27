using System;

namespace _09.SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNums = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= oddNums; i++)
            {
                int currentOddnumber = i * 2 - 1;
                Console.WriteLine(currentOddnumber);
                sum += currentOddnumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
