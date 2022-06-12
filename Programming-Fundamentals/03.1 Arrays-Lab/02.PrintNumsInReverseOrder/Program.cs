using System;
using System.Linq;


namespace _02.PrintNumsInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            // Array.Reverse(array) - използва се за обръщане на стойностите в масиви


            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }

        }
    }
}
