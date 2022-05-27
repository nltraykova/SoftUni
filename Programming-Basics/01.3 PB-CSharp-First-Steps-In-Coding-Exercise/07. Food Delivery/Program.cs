using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChickenMenu = int.Parse(Console.ReadLine());
            int countFishMenu = int.Parse(Console.ReadLine());
            int countVegeterianMenu = int.Parse(Console.ReadLine());

            double priceChickenMenu = 10.35;
            double priceFishMenu = 12.40;
            double priceVegetarianMenu = 8.15;

            double billMenus = (countChickenMenu * priceChickenMenu) + (countFishMenu * priceFishMenu) + (countVegeterianMenu * priceVegetarianMenu);
            double totalBill = billMenus + billMenus * (20 / 100.0) + 2.5;

            Console.WriteLine(totalBill);

        }
    }
}
