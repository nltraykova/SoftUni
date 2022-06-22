using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0.0;
           

            while (input != "Start")
            {
                double coins = double.Parse(input);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();
            double sumLeft = sum;

            while (input2 != "End")
            {
                string product = input2.ToLower();

                switch (product)
                {
                    case "nuts":
                        if (sumLeft >= 2.0)
                        {
                            sumLeft -= 2.0;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "water":
                        if (sumLeft >= 0.7)
                        {
                            sumLeft -= 0.7;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "crisps":
                        if (sumLeft >= 1.5)
                        {
                            sumLeft -= 1.5;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "soda":
                        if (sumLeft >= 0.8)
                        {
                            sumLeft -= 0.8;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "coke":
                        if (sumLeft >= 1.0)
                        {
                            sumLeft -= 1.0;
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                input2 = Console.ReadLine();

            }

            Console.WriteLine($"Change: {sumLeft:f2}");
        }
    }
}
