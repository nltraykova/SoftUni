using System;

namespace _04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); ///бюджет за актьори
            string input = Console.ReadLine(); //име на актьор или командата "ACTION"

            double salary = 0.0; //възнаграждението на един актъор

            while (input != "ACTION")
            {
                if (input.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                }
                else
                {
                    salary = budget * 0.2;
                }

                if (salary >= budget)
                {
                    break;
                }

                budget -= salary;

                input = Console.ReadLine();
            }

            if (input == "ACTION")
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"We need {salary - budget:f2} leva for our actors.");
            }
        }
    }
}
