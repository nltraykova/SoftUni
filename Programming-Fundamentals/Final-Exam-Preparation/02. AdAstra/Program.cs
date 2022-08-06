using System;
using System.Text.RegularExpressions;

namespace _02._AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string productPattern = @"(#{1}|\|{1})(?<product>[A-Za-z\s]+)\1(?<expDate>[0-9]{2}/[0-9]{2}/[0-9]{2})\1(?<calories>[0-9]+)\1";

            string text = Console.ReadLine();

            MatchCollection productsInfo = Regex.Matches(text, productPattern);

            int totalCalories = 0;

            foreach (Match product in productsInfo)
            {
                int productCalories = int.Parse(product.Groups["calories"].Value);

                totalCalories += productCalories;
            }

            int daysLast = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {daysLast} days!");

            foreach (Match product in productsInfo)
            {
                Console.WriteLine($"Item: {product.Groups["product"].Value}, Best before: {product.Groups["expDate"].Value}, Nutrition: {product.Groups["calories"].Value}");
            }
        }
    }
}
