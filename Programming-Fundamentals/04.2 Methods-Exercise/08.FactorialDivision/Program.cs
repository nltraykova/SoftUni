using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine()); //!5 = 1x2x3x4x5
            int secondInt = int.Parse(Console.ReadLine());

            int factorialFirstNum = FactorialInt(firstInt);
            int factorialSecondNum = FactorialInt(secondInt);
            int finalResult = Division(factorialFirstNum, factorialSecondNum);
            
            Console.WriteLine($"{finalResult:f2}");
        }

        static int Division(int firstNum, int secondNum) => firstNum / secondNum;
       

        static int FactorialInt(int num)
        {
            int factorial = 1;

            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
