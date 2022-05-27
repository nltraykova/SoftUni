using System;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine(); //прожекция - "John Wick", "Star Wars" или "Jumanji"
            string filmPackage = Console.ReadLine(); //пакет за филм - "Drink", "Popcorn" или "Menu"
            int tickets = int.Parse(Console.ReadLine()); //брой билети - цяло число в интервала[1… 30]

            double price = 0.0; //цена за билет
            
            switch (filmName)
            {
                case "John Wick":
                    if (filmPackage == "Drink")
                    {
                        price = 12;
                    }
                    else if (filmPackage == "Popcorn")
                    {
                        price = 15;
                    }
                    else if (filmPackage == "Menu")
                    {
                        price = 19;
                    }
                    break;
                case "Star Wars":
                    if (filmPackage == "Drink")
                    {
                        price = 18;
                    }
                    else if (filmPackage == "Popcorn")
                    {
                        price = 25;
                    }
                    else if (filmPackage == "Menu")
                    {
                        price = 30;
                    }

                    if (tickets >= 4)
                    {
                        price -= price * 0.3;
                    }

                    break;
                case "Jumanji":
                    if (filmPackage == "Drink")
                    {
                        price = 9;
                    }
                    else if (filmPackage == "Popcorn")
                    {
                        price = 11;
                    }
                    else if (filmPackage == "Menu")
                    {
                        price = 14;
                    }

                    if (tickets == 2)
                    {
                        price -= price * 0.15;
                    }

                    break;
            }

            double totalPrice = price * tickets;

            Console.WriteLine($"Your bill is {totalPrice:f2} leva.");

        }
    }
}
