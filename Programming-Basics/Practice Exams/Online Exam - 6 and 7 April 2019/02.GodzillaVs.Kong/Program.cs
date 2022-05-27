using System;

namespace _02.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); //бюджет за филма
            int people = int.Parse(Console.ReadLine()); //брой статисти
            double priceClothes = double.Parse(Console.ReadLine()); //облекло за един статист

            double decor = budget * 0.1;

            double totalPriceClothes = people * priceClothes;

            if (people > 150)
            {
                totalPriceClothes -= totalPriceClothes*0.1;
            }

            double totalCosts = totalPriceClothes + decor; //общи разходи - цени за дрехи на статистите + декор


            if (totalCosts > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalCosts - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCosts:F2} leva left.");
            }
        }
    }
}
