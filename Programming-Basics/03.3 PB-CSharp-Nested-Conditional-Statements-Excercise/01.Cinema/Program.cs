using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double price = 0;
            
            switch (projection)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                default:
                    price = 5.0;
                    break;
            }

            double income = r * c * price;

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
