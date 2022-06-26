using System;

namespace _01.GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodKg = double.Parse(Console.ReadLine());
            double hayKg = double.Parse(Console.ReadLine());
            double coverKg = double.Parse(Console.ReadLine());
            double weightPigKg = double.Parse(Console.ReadLine());

            double currFoodGr = foodKg * 1000;
            double currHayGr = hayKg * 1000;
            double currCoverGr = coverKg * 1000;
            double weightPigGr = weightPigKg * 1000;

            
            for (int i = 1; i <= 30; i++)
            {
                currFoodGr -= 300;

                if (i % 2 == 0)
                {
                    currHayGr -= currFoodGr * 0.05;
                }

                if (i % 3 == 0)
                {
                    currCoverGr -= weightPigGr / 3;
                }

                if (currFoodGr <= 0 || currHayGr <= 0 || currCoverGr <= 0)
                {
                    break;
                }
            }

            double excessFood = currFoodGr / 1000;
            double excessHay = currHayGr / 1000;
            double excessCover = currCoverGr / 1000;
           

            if (currFoodGr > 0 && currHayGr > 0 && currCoverGr > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {excessFood:f2}, Hay: {excessHay:f2}, Cover: {excessCover:f2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }


        }
    }
}
