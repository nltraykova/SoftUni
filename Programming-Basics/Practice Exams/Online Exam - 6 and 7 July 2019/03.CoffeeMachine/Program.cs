using System;

namespace _03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinkType = Console.ReadLine(); // вид напитка - Espresso, Cappuccino или Tea
            string sugar = Console.ReadLine(); // захар - Without, Normal или Extra
            int drinkQty = int.Parse(Console.ReadLine()); // брой напитки

            double totalPrice = 0.00;

            switch (drinkType)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        totalPrice = drinkQty * 0.90;
                        totalPrice -= totalPrice * 0.35;
                    }
                    if (sugar == "Normal")
                    {
                        totalPrice = drinkQty * 1.00;
                    }
                    if (sugar == "Extra")
                    {
                        totalPrice = drinkQty * 1.20;
                    }
                    if (drinkQty >= 5)
                    {
                        totalPrice -= totalPrice * 0.25;
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        totalPrice = drinkQty * 1.00;
                        totalPrice -= totalPrice * 0.35;
                    }
                    if (sugar == "Normal")
                    {
                        totalPrice = drinkQty * 1.20;
                    }
                    if (sugar == "Extra")
                    {
                        totalPrice = drinkQty * 1.60;
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        totalPrice = drinkQty * 0.50;
                        totalPrice -= totalPrice * 0.35;
                    }
                    if (sugar == "Normal")
                    {
                        totalPrice = drinkQty * 0.60;
                    }
                    if (sugar == "Extra")
                    {
                        totalPrice = drinkQty * 0.70;
                    }
                    break;
            }

            if (totalPrice > 15.00)
            {
                totalPrice -= totalPrice * 0.20;
            }

            Console.WriteLine($"You bought {drinkQty} cups of {drinkType} for {totalPrice:f2} lv.");

        }
    }
}
