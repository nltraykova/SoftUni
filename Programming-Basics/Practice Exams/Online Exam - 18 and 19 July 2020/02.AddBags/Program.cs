using System;

namespace _02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOver20kg = double.Parse(Console.ReadLine()); //цена на багаж над 20 кг.
            double kg = double.Parse(Console.ReadLine()); //килограми на багажа
            int days = int.Parse(Console.ReadLine()); //дни до пътуването
            int luggageCount = int.Parse(Console.ReadLine()); ///брой багаж

            double price = 0.0; //цена на багажа


            if (kg < 10)
            {
                price = priceOver20kg * 0.2;
                
                if (days < 7)
                {
                    price += price * 0.4;
                }
                else if (days <= 30)
                {
                    price += price * 0.15;
                }
                else
                {
                    price += price * 0.1;
                }
            }
            else if (kg <= 20)
            {
                price = priceOver20kg * 0.5;
                
                if (days < 7)
                {
                    price += price * 0.4;
                }
                else if (days <= 30)
                {
                    price += price * 0.15;
                }
                else
                {
                    price += price * 0.1;
                }
            }
            else
            {
                price = priceOver20kg;
                
                if (days < 7)
                {
                    price += price * 0.4;
                }
                else if (days <= 30)
                {
                    price += price * 0.15;
                }
                else
                {
                    price += price * 0.1;
                }
            }

            double totalPrice = price * luggageCount;

            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
