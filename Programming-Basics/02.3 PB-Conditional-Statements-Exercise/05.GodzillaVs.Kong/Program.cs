using System;

namespace _05.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int sQuantity = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());

            double dressSum = sQuantity * dressPrice;
            double decorSum = budget * 0.1;

            if (sQuantity > 150)
            {
                dressSum = dressSum - (dressSum * 0.1);
            }

            double totalCost = dressSum + decorSum;

            double difference = budget - totalCost;

            if (difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):F2} leva more.");
            }
        }
    }
}
