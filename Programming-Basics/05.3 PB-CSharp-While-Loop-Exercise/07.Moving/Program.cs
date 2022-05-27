using System;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hеight = int.Parse(Console.ReadLine());

            int Boxes = width * lenght * hеight;
            int countBoxes = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                countBoxes += int.Parse(input);

                if (countBoxes >= Boxes)
                {
                    break;
                }

                input = Console.ReadLine();

            }

            if (input == "Done")
            {
                Console.WriteLine($"{Boxes - countBoxes} Cubic meters left.");
            }

            if (countBoxes >= Boxes)
            {
                Console.WriteLine($"No more free space! You need {countBoxes - Boxes} Cubic meters more.");
            }
        }
    }
}
