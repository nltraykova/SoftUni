using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double priceShoes = annualTax - annualTax*(40 / 100.0);
            double priceOutfit = priceShoes - priceShoes * (20 / 100.0);
            double priceBall = priceOutfit / 4;
            double priceAccessories = priceBall / 5;

            double totalSum = annualTax + priceShoes + priceOutfit + priceBall + priceAccessories;

            Console.WriteLine(totalSum);
        }
    }
}
