using System;

namespace _03.Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()); // 1
            int min = int.Parse(Console.ReadLine()); // 5

            int time = (min + h * 60) + 15; // (5 + 1*60) + 15 = 80 

            h = time / 60; // 80 / 60 = 1
            min = time % 60; // 80 % 60 = 20


            if (h > 23)
            {
                h = 0;
            }
            
            if (min < 10)
            {
                Console.WriteLine($"{h}:0{min}");
            }
            else
            {
                Console.WriteLine($"{h}:{min}");
            }

        }
    }
}
