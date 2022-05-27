using System;

namespace PetShop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int piecesFoodDogs = int.Parse(Console.ReadLine());
            int piecesFoodCats = int.Parse(Console.ReadLine());
            double priceDogs = piecesFoodDogs * 2.5;
            double priceCats = piecesFoodCats * 4;
            double finalSum = priceDogs + priceCats;

            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
