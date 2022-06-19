using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sumResult = SumOfInt(firstNum, secondNum);
            int subtractResult = SubtractInt(sumResult, thirdNum);

            Console.WriteLine(subtractResult);
        }

        static int SubtractInt(int firstNum, int secondNum) => firstNum - secondNum;

        static int SumOfInt(int firstNum, int secondNum) => firstNum + secondNum;
    }
}
