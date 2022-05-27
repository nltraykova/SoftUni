using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (flowerType)
            {
                case "Roses":
                    price = flowerQuantity * 5;
                    if (flowerQuantity > 80)
                    {
                        price -= price * 0.1;
                    }
                    break;
                case "Dahlias":
                    price = flowerQuantity * 3.8;
                    if (flowerQuantity > 90)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = flowerQuantity * 2.8;
                    if (flowerQuantity > 80)
                    {
                        price -= price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = flowerQuantity * 3.0;
                    if (flowerQuantity < 120)
                    {
                        price += price * 0.15;
                    }
                    break;
                default:
                    price = flowerQuantity * 2.5;
                    if (flowerQuantity < 80)
                    {
                        price += price * 0.20;
                    }
                    break;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
        }
    }
}
