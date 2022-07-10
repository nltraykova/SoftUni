using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countOfOccurences = new Dictionary<string, int>();
            
            string[] words = Console.ReadLine().ToLower().Split();

            foreach (var word in words)
            {
                if (! countOfOccurences.ContainsKey(word))
                {
                    countOfOccurences.Add(word, 0);
                }

                countOfOccurences[word]++;
            }


            string[] wordsOddOccurences = countOfOccurences.Where(count => count.Value % 2 != 0).Select(count => count.Key).ToArray();

            Console.WriteLine(string.Join(' ', wordsOddOccurences));

        }
    }
}
