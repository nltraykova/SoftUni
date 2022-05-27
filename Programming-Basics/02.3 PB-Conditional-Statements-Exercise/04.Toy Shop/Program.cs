using System;

namespace _04.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int bearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());

            int totalQuantity = puzzlesQuantity + dollsQuantity + bearsQuantity + minionsQuantity + trucksQuantity;
            
            double totalSum = puzzlesQuantity * 2.6 + dollsQuantity * 3 + bearsQuantity * 4.1 + minionsQuantity * 8.2 + trucksQuantity * 2;

            if (totalQuantity >= 50)
            {
                totalSum = totalSum - totalSum * 0.25;
            }

            totalSum = totalSum - totalSum * 0.1;

            double difference = totalSum - tripPrice;

            if (totalSum >= tripPrice)
            {
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):F2} lv needed.");
            }


        }
    }
}
