using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._1.Orders___solution_with_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            
            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productInfo = input.Split();
                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                int productQuantity = int.Parse(productInfo[2]);

                if (! products.Any(p => p.ProductName == productName))
                {
                    Product product = new Product(productName, productPrice, productQuantity);
                    products.Add(product);
                }
                else
                {
                    Product product = products.Find(p => p.ProductName == productName);
                    product.ProductPrice = productPrice;
                    product.ProductQuantity += productQuantity;
                }
                
                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.ProductPrice * product.ProductQuantity;

                Console.WriteLine($"{product.ProductName} -> {totalPrice:f2}");
            }
        }
    }

    class Product
    {
        public Product(string productName, double productPrice, int productQuantity)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.ProductQuantity = productQuantity;
        }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
