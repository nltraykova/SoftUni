using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;


            for (int currOrder = 1; currOrder <= countOfOrders; currOrder++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double priceOfCurrOrder = ((daysInMonth * capsulesCount) * pricePerCapsule);

                totalPrice += priceOfCurrOrder;

                Console.WriteLine($"The price for the coffee is: ${priceOfCurrOrder:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
