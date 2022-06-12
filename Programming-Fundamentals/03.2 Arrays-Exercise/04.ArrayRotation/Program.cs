using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfRotations; i++)
            {
                int tempFirstElement = arr1[0];

                for (int j = 0; j < arr1.Length-1; j++)
                {
                    arr1[j] = arr1[j + 1];
                }

                arr1[arr1.Length - 1] = tempFirstElement;
            }

            Console.WriteLine(string.Join(' ', arr1));

        }
    }
}
