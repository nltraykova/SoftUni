using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //First way

            string[] array = { "Ivan", "Georgi", "Petar", "Teodor" };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            //Second way

            Console.WriteLine();
            Console.WriteLine(string.Join(" - ", array));
        }
    }
}
