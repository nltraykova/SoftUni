using System;
using System.Text.RegularExpressions;

namespace _02._EasterEggs
{
    class Program
    {
        static void Main(string[] args)

        {
            string patternEggs = @"(@+|#+)(?<egg>[a-z]{3,})(@+|#+)([^A-Za-z0-9]*)\/+(?<amount>[0-9]+)\/+";

            string EggsInfo = Console.ReadLine();

            MatchCollection matchEggs = Regex.Matches(EggsInfo, patternEggs);

            foreach (Match egg in matchEggs)
            {
                Console.WriteLine($"You found {egg.Groups["amount"]} {egg.Groups["egg"]} eggs!");
            }
        }
    }
}
