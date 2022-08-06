using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternWordPairs = @"(#{1}|@{1})(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            List<string> mirrorWords = new List<string>();

            string text = Console.ReadLine();

            MatchCollection wordPairs = Regex.Matches(text, patternWordPairs);

            if (Regex.IsMatch(text, patternWordPairs))
            {
                Console.WriteLine($"{wordPairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            foreach (Match match in wordPairs)
            {
                string firstWord = match.Groups["first"].Value;
                string secondWord = match.Groups["second"].Value;

                bool isMirrorWord = true;

                if (firstWord.Length != secondWord.Length)
                {
                    isMirrorWord = false;
                    continue;
                }

                string reversedSecondWord = string.Empty;

                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedSecondWord += secondWord[i];
                }

                
                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (firstWord[i] != reversedSecondWord[i])
                    {
                        isMirrorWord = false;
                        break;
                    }
                }
                
                if (isMirrorWord)
                {
                    mirrorWords.Add($"{firstWord} <=> {secondWord}");
                }
            }

            if (mirrorWords.Count != 0)
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));
            }
            else
            {
                Console.WriteLine($"No mirror words!");
            }
        }
    }
}
