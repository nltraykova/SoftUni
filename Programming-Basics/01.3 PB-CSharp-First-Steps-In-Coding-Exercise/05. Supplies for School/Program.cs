using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int litersPrep = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePens = 5.8;
            double priceMarkers = 7.2;
            double pricePrep = 1.2;

            double sum = (countMarkers * priceMarkers) + (countPens * pricePens) + (litersPrep * pricePrep);

            double finalSum = sum - sum * (discount / 100.00);

            Console.WriteLine(finalSum);
        }
    }
}
