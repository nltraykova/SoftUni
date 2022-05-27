using System;

namespace _02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); // разполагаем бюджет
            int nightsQty = int.Parse(Console.ReadLine()); // брой нощувки
            double nightPrice = double.Parse(Console.ReadLine()); //цена за 1 нощувка
            int otherCostsPercent = int.Parse(Console.ReadLine()); //процент допълнителни разходи

            double otherCosts = budget * (otherCostsPercent / 100.0); //допълнителни разходи

            if (nightsQty > 7)
            {
                nightPrice = nightPrice - nightPrice * 0.05;
            }

            double costs = nightsQty * nightPrice + otherCosts;

            if (budget >= costs)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - costs:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{costs - budget:f2} leva needed.");
            }

        }
    }
}
