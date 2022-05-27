using System;

namespace _01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuettеs =  rent - rent *0.3;
            double catering = statuettеs - statuettеs * 0.15;
            double sound = catering / 2;

            double costs = rent + statuettеs + catering + sound;


            Console.WriteLine($"{costs:F2}");
        }
    }
}
