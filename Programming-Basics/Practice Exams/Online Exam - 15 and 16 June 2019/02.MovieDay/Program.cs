using System;

namespace _02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine()); //1.Планирано време за снимки – цяло число в диапазона[0… 1440]
            int scenesCount = int.Parse(Console.ReadLine()); // 2.Брой сцени  – цяло число в диапазона[5… 25]
            int sceneTime = int.Parse(Console.ReadLine()); //3.Времетраене на сцена – цяло число в диапазона[20… 90]

            double preparing = time * 0.15; //време за подготовка на терен - 15 процента от времето за снимки

            double totalTime = scenesCount * sceneTime + preparing; //реално време за снимки

            if (totalTime <= time)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(time - totalTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {totalTime - time} minutes.");
            }

        }
    }
}
