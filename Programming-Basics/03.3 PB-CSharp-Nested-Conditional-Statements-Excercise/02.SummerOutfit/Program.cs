using System;

namespace _02.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "Shirt";
            string shoes = "Moccasins";

            switch (time)
            {
                case "Morning":
                    if (degrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degrees <=24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
            }
            
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
