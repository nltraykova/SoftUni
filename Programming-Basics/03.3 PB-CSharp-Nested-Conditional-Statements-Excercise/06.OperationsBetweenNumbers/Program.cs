using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
           
            double result = 0;
            
            switch (op)
            {
                case '+':
                case '-':
                case '*':
                    if (op == '+')
                    {
                        result = num1 + num2;
                    }
                    else if (op == '-')
                    {
                        result = num1 - num2;
                    }
                    else if (op == '*')
                    {
                        result = num1 * num2;
                    }

                    string evenOrOdd = "odd";

                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                   
                    Console.WriteLine($"{num1} {op} {num2} = {result} - {evenOrOdd}");
                   
                    break;
                default:
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        if (op == '/')
                        {
                            result = 1.0 * num1 / num2;
                            Console.WriteLine($"{num1} {op} {num2} = {result:F2}");
                        }
                        else
                        {
                            result = num1 % num2;
                            Console.WriteLine($"{num1} {op} {num2} = {result}");
                        }
                    }
                    break;
            }
        }
    }
}
