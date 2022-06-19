using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(NumberOfVowels(input));
        }

        static int NumberOfVowels(string input) => input.Count(vowels => "auoei".Contains(vowels));

    }
}
