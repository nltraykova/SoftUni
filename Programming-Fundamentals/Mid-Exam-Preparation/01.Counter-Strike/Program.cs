using System;

namespace _01.Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int currEnergy = initialEnergy;
            int wonGamesCount = 0;

            string input = Console.ReadLine();
           

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (currEnergy >= distance)
                {
                    currEnergy -= distance;
                    wonGamesCount++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonGamesCount} won battles and {currEnergy} energy");
                    return;
                }

                if (wonGamesCount % 3 == 0)
                {
                    currEnergy += wonGamesCount;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonGamesCount}. Energy left: {currEnergy}");
        }
    }
}
