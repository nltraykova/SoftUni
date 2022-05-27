using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine()); //брой места в залата
            string input = Console.ReadLine(); //брой хора, влизащи в залата или командата "Movie time!"
            double totalPrice = 0.0;

            while (input != "Movie time!")
            {
                
                if (int.Parse(input) > capacity)
                {
                    break;
                }

                capacity -= int.Parse(input);

                double price = int.Parse(input) * 5;

                if (int.Parse(input) % 3 == 0)
                {
                    price -= 5;
                }

                totalPrice += price;
                
                input = Console.ReadLine();

            }

            if (input == "Movie time!")
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema."); 
            }
            else if (int.Parse(input) > capacity)
            {
                Console.WriteLine($"The cinema is full.");
            }
            
            Console.WriteLine($"Cinema income - {totalPrice} lv.");

        }
    }
}
