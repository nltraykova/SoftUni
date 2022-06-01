using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustingFactor = int.Parse(Console.ReadLine());

            int targetPokemons = 0;
            int currentPower = power;

            
            while (currentPower >= distance)
            {
                currentPower -= distance;
                targetPokemons++;

                if (currentPower == (double)power * 0.5 && exaustingFactor > 0)
                {
                    currentPower /= exaustingFactor;
                }
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(targetPokemons);
        }
    }
}
