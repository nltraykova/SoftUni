using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productInfo = input.Split();
                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                double productQuantity = double.Parse(productInfo[2]);

                
                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new List<double> { productPrice, 0 });
                }

                double newProductQuantity = products[productName][1] + productQuantity;
                
                products[productName] = new List<double> { productPrice, newProductQuantity };

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
