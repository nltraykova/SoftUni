using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double account = 0;
            string payment = Console.ReadLine();
           

            while (payment != "NoMoreMoney")
            {
                double amount = double.Parse(payment);

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                Console.WriteLine($"Increase: {amount:F2}");
                account += amount;
                payment = Console.ReadLine();
            }

            Console.WriteLine($"Total: {account:F2}");
        }
    }
}
