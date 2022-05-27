using System;

namespace _09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();

            double totalPrice = 0.0;
            int nights = days - 1;

            switch (roomType)
            {
                case "room for one person":
                    double priceRoom = 18;
                    totalPrice = nights * priceRoom;
                    break;
                case "apartment":
                    double priceApartment = 25;
                    totalPrice = nights * priceApartment;
                    if (days < 10)
                    {
                        totalPrice -= totalPrice * 0.3;
                    }
                    else if (days < 15)
                    {
                        totalPrice -= totalPrice * 0.35;
                    }
                    else //>15
                    {
                        totalPrice -= totalPrice * 0.5;
                    }
                    break;
                case "president apartment":
                    double pricePresidentApartment = 35;
                    totalPrice = nights * pricePresidentApartment;
                    if (days < 10)
                    {
                        totalPrice -= totalPrice * 0.1;
                    }
                    else if (days < 15)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    else //>15
                    {
                        totalPrice -= totalPrice * 0.2;
                    }
                    break;
            }
            
            if (rate == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else // negative
            {
                totalPrice -= totalPrice * 0.1;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}

