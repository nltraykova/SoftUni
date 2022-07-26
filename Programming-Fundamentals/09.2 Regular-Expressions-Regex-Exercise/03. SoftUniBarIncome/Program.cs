using System;
using System.Text.RegularExpressions;

namespace _03._SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(%)(?<customer>[A-Z][a-z]+)\1[^$.%|]*<(?<product>\w+)>[^$.%|]*(\|)(?<quantity>[0-9]+)\2[^$.%|]*?(?<price>\d+.?\d+)?\$";
            double totalIncome = 0.0;
            
            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);

                Match order = regex.Match(input);

                
                if (order.Success)
                {
                    string customer = order.Groups["customer"].Value;
                    string product = order.Groups["product"].Value;
                    int quantity = int.Parse(order.Groups["quantity"].Value);
                    double price = double.Parse(order.Groups["price"].Value);
                    double totalPrice = 0.0;

                    totalPrice = quantity * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
                
                input = Console.ReadLine();
            }


            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
