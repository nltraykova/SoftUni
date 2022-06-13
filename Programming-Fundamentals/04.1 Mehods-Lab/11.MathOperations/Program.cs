using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            
            Console.WriteLine(ResultOfOperations(num1, @operator, num2));

        }

        static double ResultOfOperations(double num1, char @operator, double num2)
        {
            double result = 0;

            switch (@operator)
            {
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
            }

            return result;
        }
    }
}
