using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //number = 20
            double bonus = 0; //0

            if (number <= 100)
            {
                bonus = 5; //bonus = 5
            }
            else if (number > 100 && number <= 1000)
            {
                bonus = number * 0.2;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }

            if ((number % 2) == 0) 
            {
                bonus = (bonus + 1); // bonus = 5 + 1 = 6
            }

            if ((number % 10) == 5)
            {
                bonus = (bonus + 2);
            }

            Console.WriteLine(bonus); //6
            Console.WriteLine(number + bonus); //20 + 6
        }
    }
}
