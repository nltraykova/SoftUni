using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+.?\d+)!(?<quantity>\d+)";

            List<string> furnitures = new List<string>();
            double totalSum = 0.0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    totalSum += price * quantity;

                    furnitures.Add(name);
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            furnitures.ForEach(Console.WriteLine);

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
