using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNum = tokens[0];
            int power = tokens[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                    Detonation(i, power, numbers);
                }
            }

            Console.WriteLine(numbers.Sum());
        }

        static void Detonation(int index, int power, List<int> numbers)
        {
            int start = Math.Max(0, index - power);
            int end = Math.Min(numbers.Count - 1, index + power);

            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
