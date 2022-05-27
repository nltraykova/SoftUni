using System;

namespace _01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int secCompetitor1 = int.Parse(Console.ReadLine());
            int secCompetitor2 = int.Parse(Console.ReadLine());
            int secCompetitor3 = int.Parse(Console.ReadLine());

            int totalSec = secCompetitor1 + secCompetitor2 + secCompetitor3; //50 сек. + 50 сек. + 50 сек. = 150 сек. = 2 мин. 30 сек.

            int min = totalSec / 60; //150 / 60 = 2
            int sec = totalSec % 60; //150 % 60 = 30

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
} 