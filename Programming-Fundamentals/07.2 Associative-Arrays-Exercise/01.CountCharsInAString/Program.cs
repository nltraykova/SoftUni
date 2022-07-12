using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letterOccurrences = new Dictionary<char, int>();

            string stringOfLetters = Console.ReadLine();

            foreach (var letter in stringOfLetters)
            {
                if (letter != ' ')
                {
                    if (!letterOccurrences.ContainsKey(letter))
                    {
                        letterOccurrences.Add(letter, 0);
                    }

                    letterOccurrences[letter]++;
                }
            }

            foreach (var letter in letterOccurrences)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
