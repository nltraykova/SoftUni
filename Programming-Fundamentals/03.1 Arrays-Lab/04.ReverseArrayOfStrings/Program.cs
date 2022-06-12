using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();

            // Array.Reverse(array) - използва се за обръщане на стойностите в масиви

            for (int i = 0; i < array.Length / 2; i++)
            {
                string frontElement = array[i];
                string backElement = array[(array.Length-1) - i];
                array[i] = backElement;
                array[(array.Length - 1) - i] = frontElement;
            }

                Console.Write(string.Join(' ', array));
        }
    }
}
