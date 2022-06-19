using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfProduct = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < linesOfProduct; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            int numeration = 0;

            foreach (var product in products)
            {
                numeration++;
                Console.WriteLine($"{numeration}.{product}");
            }
        }
    }
}
