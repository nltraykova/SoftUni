using System;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBalls = int.Parse(Console.ReadLine());

            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int blackCount = 0;
            int othersCount = 0;
            
            double points = 0.0;

            for (int i = 1; i <= numBalls; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    points += 5;
                    redCount++;
                }
                else if (color == "orange")
                {
                    points += 10;
                    orangeCount++;
                }
                else if (color == "yellow")
                {
                    points += 15;
                    yellowCount++;
                }
                else if (color == "white")
                {
                    points += 20;
                    whiteCount++;
                }
                else if (color == "black")
                {
                    points /= 2;
                    Math.Floor(points);
                    blackCount++;
                }
                else
                {
                    othersCount++;
                }
            }
            
            Console.WriteLine($"Total points: {Math.Floor(points)}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {othersCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");
        }
    }
}
