using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int sumOfEvens = 0;
                int sumOfOdds = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        sumOfEvens += array[i];
                    }
                    else
                    {
                        sumOfOdds += array[i];
                    }
                }

                Console.WriteLine(sumOfEvens - sumOfOdds);
            }
        }
    }
}
