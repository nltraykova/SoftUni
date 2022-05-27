using System;

namespace _03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); // Бюджет на филма – реално число в диапазона[100 000.0… 2 000 000.0]
            string destination = Console.ReadLine(); //Дестинация – "Dubai", "Sofia" и "London"
            string season = Console.ReadLine(); //Сезон – "Summer" и "Winter"
            int days = int.Parse(Console.ReadLine()); //Брой дни  – цяло число в диапазона[1… 40]

            double price = 0.0;
            
            switch (destination)
            {
                case "Dubai":
                    if (season == "Winter")
                    {
                        price = 45000;
                    }
                    else if (season == "Summer")
                    {
                        price = 40000;
                    }
                    break;
                case "Sofia":
                    if (season == "Winter")
                    {
                        price = 17000;
                    }
                    else if (season == "Summer")
                    {
                        price = 12500;
                    }
                    break;
                case "London":
                    if (season == "Winter")
                    {
                        price = 24000;
                    }
                    else if (season == "Summer")
                    {
                        price = 20250;
                    }
                    break;
            }

            double totalPrice = price * days; //цената за заснемане на филма

            if (destination == "Dubai")
            {
                totalPrice -= totalPrice * 0.3;
            }
            else if (destination == "Sofia")
            {
                totalPrice += totalPrice * 0.25;
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice - budget:f2} leva more!");
            }

        }
    }
}
