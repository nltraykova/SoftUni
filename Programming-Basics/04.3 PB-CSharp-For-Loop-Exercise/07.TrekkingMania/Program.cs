using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double musala = 0.0;
            double monblan = 0.0;
            double kilimandzharo = 0.0;
            double k2 = 0.0;
            double everest = 0.0;

            int totalNumberOfPeople = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine()); 

                totalNumberOfPeople+= numberOfPeople; 

                if (numberOfPeople <= 5)
                {
                    musala += numberOfPeople;
                }
                else if (numberOfPeople <= 12)
                {
                    monblan += numberOfPeople;
                }
                else if (numberOfPeople <= 25)
                {
                    kilimandzharo += numberOfPeople;
                }
                else if (numberOfPeople <= 40)
                {
                    k2 += numberOfPeople;
                }
                else
                {
                    everest += numberOfPeople;
                }
            }

            Console.WriteLine($"{(musala / totalNumberOfPeople) * 100:F2}%");
            Console.WriteLine($"{(monblan / totalNumberOfPeople) * 100:F2}%");
            Console.WriteLine($"{(kilimandzharo / totalNumberOfPeople) * 100:F2}%");
            Console.WriteLine($"{(k2 / totalNumberOfPeople) * 100:F2}%");
            Console.WriteLine($"{(everest / totalNumberOfPeople) * 100:F2}%");
        }
    }
}
