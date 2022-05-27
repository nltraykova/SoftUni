using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double price = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.3;
                }
                else
                {
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;
                }
                else
                {
                    price = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                price = budget * 0.9;
            }

            string vacationType = "";
            
            if (season == "summer" && destination != "Europe")
            {
                vacationType = "Camp";
            }
            else
            {
                vacationType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {price:F2}");
        }
    }
}
