using System;

namespace _01.ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            // grade >= 5.50; grade < 5.50

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
