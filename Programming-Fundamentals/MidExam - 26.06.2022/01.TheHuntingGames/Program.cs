using System;

namespace _01.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numOfPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());


            double totalWater = waterPerDay * days * numOfPlayers;
            double totalFood = foodPerDay * days * numOfPlayers;
            
            double currEnergy = energy;

          

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                currEnergy -= energyLoss;

                if (currEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    currEnergy += currEnergy * 0.05;
                    totalWater -= totalWater * 0.30;
                }

                if (i % 3 == 0)
                {
                    currEnergy += currEnergy * 0.10;
                    totalFood -= totalFood / numOfPlayers;
                }
            }

            if (currEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {currEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }
        }
    }
}
