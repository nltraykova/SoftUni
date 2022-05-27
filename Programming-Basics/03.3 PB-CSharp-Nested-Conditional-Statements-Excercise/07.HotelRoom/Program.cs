using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApartment = 65;
                    if (nights > 7 && nights < 14)
                    {
                        priceStudio -= priceStudio * 0.05;
                    }
                    else if (nights > 14)
                    {
                        priceStudio -= priceStudio * 0.3;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                    if (nights > 14)
                    {
                        priceStudio -= priceStudio * 0.20;
                    }
                    break;
                default: //July or August
                    priceStudio = 76;
                    priceApartment = 77;
                    break;
            }

            if (nights > 14)
            {
                priceApartment -= priceApartment * 0.1;
            }

            double finalPriceApartment = priceApartment * nights;
            double finalPriceStudio = priceStudio * nights;

            Console.WriteLine($"Apartment: {finalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {finalPriceStudio:F2} lv.");
        }
    }
}
