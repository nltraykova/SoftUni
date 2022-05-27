using System;

namespace _03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine(); //"A Star Is Born", "Bohemian Rhapsody","Green Book" или "The Favourite"
            string hallType = Console.ReadLine(); //"normal", "luxury" или "ultra luxury"
            int ticketsCount = int.Parse(Console.ReadLine()); //брой на закупените билети

            double price = 0.0;
            
            switch (filmName)
            {
                case "A Star Is Born":
                    if (hallType == "normal")
                    {
                        price = 7.50;
                    }
                    else if (hallType == "luxury")
                    {
                        price = 10.50;
                    }
                    else if (hallType == "ultra luxury")
                    {
                        price = 13.50;
                    }
                    break;
                case "Bohemian Rhapsody":
                    if (hallType == "normal")
                    {
                        price = 7.35;
                    }
                    else if (hallType == "luxury")
                    {
                        price = 9.45;
                    }
                    else if (hallType == "ultra luxury")
                    {
                        price = 12.75;
                    }
                    break;
                case "Green Book":
                    if (hallType == "normal")
                    {
                        price = 8.15;
                    }
                    else if (hallType == "luxury")
                    {
                        price = 10.25;
                    }
                    else if (hallType == "ultra luxury")
                    {
                        price = 13.25;
                    }
                    break;
                case "The Favourite":
                    if (hallType == "normal")
                    {
                        price = 8.75;
                    }
                    else if (hallType == "luxury")
                    {
                        price = 11.55;
                    }
                    else if (hallType == "ultra luxury")
                    {
                        price = 13.95;
                    }
                    break;
            }

            double totalPrice = price * ticketsCount; //общата цена - цена на билет за конкретния филм според залата * закупените билети

            Console.WriteLine($"{filmName} -> {totalPrice:F2} lv.");

        }
    }
}
