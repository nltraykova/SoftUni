using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string pattern = @"\b(?<day>[0-9]{2})([-./])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchDates = regex.Matches(dates);

            foreach (Match date in matchDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
