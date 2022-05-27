using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serieName = Console.ReadLine();
            int serieTime = int.Parse(Console.ReadLine()); //48 мин.
            int breakTime = int.Parse(Console.ReadLine()); //60 мин.

            // Време за сериал = Време за обедна почивка - Време за отдих - Време за обяд

            double lunchTime = breakTime * 1 / 8.0; // 60 / 8 = 7.5
            double relaxTime = breakTime * 1 / 4.0; // 60 / 4 = 15

            double serieTimeLeft = breakTime - lunchTime - relaxTime; //60 - 7.5 - 15 = 37.5

            if ((serieTimeLeft - serieTime) >= 0)
            {
                Console.WriteLine
                    ($"You have enough time to watch {serieName} and left with {Math.Ceiling(serieTimeLeft - serieTime)} minutes free time.");
            }
            else 
            {
                Console.WriteLine
                    ($"You don't have enough time to watch {serieName}, you need {Math.Ceiling(serieTime - serieTimeLeft)} more minutes.");
            }
        }
    }
}
