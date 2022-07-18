using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split((' '), StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];

                double num = double.Parse(item.Substring(1, item.Length - 2));
                double currResult = 0.0;

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    currResult = num / (firstLetter - 64);
                }
                else
                {
                    currResult = num * (firstLetter - 96);
                }


                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    currResult -= lastLetter - 64;
                }
                else
                {
                    currResult += lastLetter - 96;
                }


                sum += currResult;

            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
