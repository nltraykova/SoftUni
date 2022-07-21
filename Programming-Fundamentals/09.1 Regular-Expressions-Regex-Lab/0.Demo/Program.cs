using System;
using System.Text.RegularExpressions;

namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Nakov: 123 Marin: 567 Iva5: 175";
            string pattern = @"([A-Z][a-z]+): (?<password>[0-9]+)";
            string replacement = "***";

            Regex regex = new Regex(pattern);

            //Determines whether the text matches a given pattern
            bool isMatchesInTheText = regex.IsMatch(text);

            Console.WriteLine(isMatchesInTheText);

            Console.WriteLine();


            //Returns the first match of a given pattern
            Match match = regex.Match(text);

            Console.WriteLine(match.Groups.Count);
            Console.WriteLine(match);
            Console.WriteLine(match.Groups[1]);
            Console.WriteLine(match.Groups["password"]);

            Console.WriteLine();


            //Returns a collection of matches
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(string.Join(", ", matches));

            Console.WriteLine(matches.Count);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Groups[1]);
                Console.WriteLine(item.Groups["password"]);
            }

            Console.WriteLine();

            //Replaces all strings that match the pattern with the provided replacement
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);

            Console.WriteLine();

            //Splits the text by the pattern

            string text2 = "1, 2,   5, 7,   18";
            string pattern2 = @",\s+";

            string[] results = Regex.Split(text2, pattern2);

            Console.WriteLine(string.Join(", ", results));

        }
    }
}
