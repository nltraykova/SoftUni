using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            double biggestKegVolume = int.MinValue;
            string biggestKegModel = "";

            for (int i = 0; i < numOfKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentKegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currentKegVolume > biggestKegVolume)
                {
                    biggestKegVolume = currentKegVolume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
