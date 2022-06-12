using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int[] currentArr = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    currentSum = numbers[i] + numbers[j];
                    
                    if (currentSum == magicNum)
                    {
                        currentArr[0] = numbers[i];
                        currentArr[1] = numbers[j];
                        Console.WriteLine(string.Join(' ', currentArr));
                    }
                }
            }

        }
    }
}
