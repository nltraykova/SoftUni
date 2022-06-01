using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = int.MinValue;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            string bestFormula = "";
            

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                int snowballValue = snowballSnow / snowballTime;
                BigInteger currentSnowballValue = BigInteger.Pow(snowballValue, snowballQuality);

                if (currentSnowballValue > highestSnowballValue)
                {
                    highestSnowballValue = currentSnowballValue;
                    bestFormula = $"{snowballSnow} : {snowballTime} = {highestSnowballValue} ({snowballQuality})";
                    
                }
            }

            Console.WriteLine(bestFormula);
        }
    }
}
