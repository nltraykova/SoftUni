using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double realVolume = volume - (volume * (percent / 100.0));

            double liters = realVolume / 1000;

            Console.WriteLine(liters);
        }
    }
}
