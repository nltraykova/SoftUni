using System;

namespace _06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine()); //55 555.67 сек.
            double m = double.Parse(Console.ReadLine()); //3017 м. 
            double secForM = double.Parse(Console.ReadLine()); //5.03 сек./ м.

            double resultIvan = m * secForM; //3017 м. * 5.03 сек. = 15 175.51 сек  
            double delay = (Math.Floor(m / 15)) * 12.5; // 3017 / 15 = 201 * 12.5 = 2 512.5

            double finalResult = resultIvan + delay; //15 175.51 + 2 512.5 = 17 688.01

            double difference = finalResult - recordInSec; //17 688.01 - 55 555.67 = -37 867.66

            if (difference < 0)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalResult:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }
        }
    }
}
