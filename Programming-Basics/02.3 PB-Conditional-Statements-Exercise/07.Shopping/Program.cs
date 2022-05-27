using System;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocardsQuantity = int.Parse(Console.ReadLine());
            int processorsQuantity = int.Parse(Console.ReadLine());
            int ramQuantity = int.Parse(Console.ReadLine());

            double videocardsSum = videocardsQuantity * 250;

            double totalSum = videocardsSum + processorsQuantity * (videocardsSum * 0.35) + ramQuantity * (videocardsSum * 0.1);

            if (videocardsQuantity > processorsQuantity)
            {
                totalSum = totalSum - totalSum * 0.15;
            }

            double difference = budget - totalSum;

            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva more!");
            }
        }
    }
}
