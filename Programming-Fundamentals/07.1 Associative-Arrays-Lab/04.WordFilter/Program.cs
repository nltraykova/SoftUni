using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string[] wordsEvenLength = words.Where(word => word.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, wordsEvenLength));
        }
    }
}
