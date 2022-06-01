using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int YIELD_DECREASED = 10;
            const int WORKERS_CONSUMPTION = 26;
            const int MIN_CAPACITY = 100;

            int startingYield = int.Parse(Console.ReadLine());
            int daysCounter = 0;
            int totalAmountOfSpice = 0;

            
            while (startingYield >= MIN_CAPACITY)
            {
                totalAmountOfSpice += startingYield - WORKERS_CONSUMPTION;
                startingYield -= YIELD_DECREASED;
                daysCounter++;

                if (startingYield < MIN_CAPACITY)
                {
                    totalAmountOfSpice -= WORKERS_CONSUMPTION;
                }
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalAmountOfSpice);
        }
    }
}
