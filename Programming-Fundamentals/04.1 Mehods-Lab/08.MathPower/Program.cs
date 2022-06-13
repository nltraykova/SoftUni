using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaisedToPower(@base, power);

            Console.WriteLine(result);
        }

        static double RaisedToPower(double @base, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= @base;
            }

            return result;
        }
    }
}
