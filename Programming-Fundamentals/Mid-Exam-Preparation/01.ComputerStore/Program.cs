using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            const double TAX = 0.2;
            double totalPriceWithTaxes = 0.0;
            double totalPriceWithoutTaxes = 0.0;
            double taxesAmount = 0.0;

            while (input != "special" && input != "regular")
            {
                double currPrice = double.Parse(input);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPriceWithoutTaxes += currPrice;
                }
                
                input = Console.ReadLine();
            }

            taxesAmount = totalPriceWithoutTaxes * TAX;
            totalPriceWithTaxes = totalPriceWithoutTaxes + taxesAmount;
            
            if (input == "special")
            {
                totalPriceWithTaxes -= totalPriceWithTaxes * 0.10;
            }

            if (totalPriceWithTaxes > 0)
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxesAmount:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
