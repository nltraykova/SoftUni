using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            double price = 0.00;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            
            switch (typeOfDay)
            {
                case "Weekday":
                    if (age <= 18 || age > 64)
                    {
                        price = 12;
                    }
                    else
                    {
                        price = 18;
                    }
                    break;
                case "Weekend":
                    if (age <= 18 || age > 64)
                    {
                        price = 15;
                    }
                    else
                    {
                        price = 20;
                    }
                    break;
                case "Holiday":
                    if (age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else
                    {
                        price = 10;
                    }
                    break;
            }

            if (age >= 0 && age <= 122)
            {
                Console.WriteLine($"{price}$");
            }

        }
    }
}
