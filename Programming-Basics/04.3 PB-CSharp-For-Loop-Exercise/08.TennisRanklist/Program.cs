using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());
            
            int finalPoints = initialPoints;
            int wonTournaments = 0;

            for (int i = 1; i <= n; i++)
            {
                string position = Console.ReadLine();

                if (position == "W")
                {
                    finalPoints += 2000;
                    wonTournaments++;
                }
                else if (position == "F")
                {
                    finalPoints += 1200;
                }
                else
                {
                    finalPoints += 720;
                }
            }

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor((finalPoints - initialPoints)/ n*1.0)}");
            Console.WriteLine($"{(wonTournaments * 1.0 / n ) * 100:F2}%");
        }
    }
}
