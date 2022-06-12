using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] train = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }

            foreach (var wagon in train)
            {
                Console.Write($"{wagon} ");
            }

            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}
