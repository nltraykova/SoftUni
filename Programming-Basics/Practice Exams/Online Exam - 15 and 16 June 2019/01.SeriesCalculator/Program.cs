using System;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string serieName = Console.ReadLine(); //Име на сериал - текст
            int seasonsCount = int.Parse(Console.ReadLine());  //Брой сезони – цяло число в диапазона[1… 10]
            int episodsCount = int.Parse(Console.ReadLine());  //Брой епизоди във всеки сезон  – цяло число в диапазона[10… 80]
            double episodTime = double.Parse(Console.ReadLine());  //Времетраене на обикновен епизод без рекламите – реално число 

            episodTime += episodTime * 0.2; //времето на един епизод + времето за реклами /20% от времето на един епизод/

            int additionalTime = seasonsCount * 10; //Допълнително време за специалния епизод в края на всеки сезон;

            double totalTime = episodsCount * episodTime * seasonsCount + additionalTime;

            Console.WriteLine($"Total time needed to watch the {serieName} series is {Math.Floor(totalTime)} minutes.");

        }
    }
}
