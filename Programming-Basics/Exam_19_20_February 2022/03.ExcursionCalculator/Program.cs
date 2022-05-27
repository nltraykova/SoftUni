using System;

namespace _03.ExcursionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()); //брой хора – цяло число в интервала[1 … 20]
            string season = Console.ReadLine();  //сезон – текст- "spring", "summer", "autumn" или "winter"
            double price = 0.0; 
            
            switch (season)
            {
                case "spring":
                    
                    if (people <= 5)
                    {
                        price = people * 50;
                    }
                    else
                    {
                        price = people * 48;
                    }

                    break;
                case "summer":
                    
                    if (people <= 5)
                    {
                        price = people * 48.50;
                    }
                    else
                    {
                        price = people * 45;
                    }

                    price -= price * 0.15;

                    break;
                case "autumn":

                    if (people <= 5)
                    {
                        price = people * 60;
                    }
                    else
                    {
                        price = people * 49.50;
                    }

                    break;
                case "winter":

                    if (people <= 5)
                    {
                        price = people * 86;
                    }
                    else
                    {
                        price = people * 85;
                    }

                    price += price * 0.08;
                    
                    break;
            }

            Console.WriteLine($"{price:f2} leva.");

        }
    }
}
