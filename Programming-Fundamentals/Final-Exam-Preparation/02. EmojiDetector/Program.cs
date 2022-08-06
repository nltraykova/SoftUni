using System;
using System.Text.RegularExpressions;

namespace _02._EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternDigits = @"\d";
            string patternEmojis = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";

            string text = Console.ReadLine();


            MatchCollection matchesDigits = Regex.Matches(text, patternDigits);
            MatchCollection matchesEmojis = Regex.Matches(text, patternEmojis);

            long treshold = 1;

            foreach (Match digit in matchesDigits)
            {
                treshold *= int.Parse(digit.Value);
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{matchesEmojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in matchesEmojis)
            {
                string emojiName = emoji.Groups["emoji"].Value;

                long coolness = 0;

                foreach (var ch in emojiName)
                {
                    coolness += ch;
                }

                if (coolness >= treshold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
      
        }
    }
}
