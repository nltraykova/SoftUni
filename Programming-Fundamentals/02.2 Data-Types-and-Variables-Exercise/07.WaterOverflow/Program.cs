using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TANK_CAPACITY = 255;

            int numberOfTimesPouring = int.Parse(Console.ReadLine());
            int currentCapacity = TANK_CAPACITY;

            
            for (int i = 0; i < numberOfTimesPouring; i++)
            {
                int pourLiters = int.Parse(Console.ReadLine());

                if (currentCapacity - pourLiters >= 0)
                {
                    currentCapacity -= pourLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(TANK_CAPACITY - currentCapacity);
        }
    }
}
