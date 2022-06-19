using System;

namespace _01._SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = SmallesNumber(num1, num2, num3);

            Console.WriteLine(result);

        }

        static int SmallesNumber(int num1, int num2, int num3) => Math.Min(num1, Math.Min(num2, num3));
        
    }
}
