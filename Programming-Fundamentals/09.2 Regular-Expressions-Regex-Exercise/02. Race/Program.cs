using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfParticipants = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> participants = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string patternChars = @"[A-Za-z]+";

                Regex regexChars = new Regex(patternChars);

                MatchCollection matchesChars = regexChars.Matches(input);

                string nameOfParticipant = String.Empty;
                
                foreach (Match match in matchesChars)
                {
                    nameOfParticipant += match.Value;
                }


                if (listOfParticipants.Contains(nameOfParticipant))
                {
                    string patternDigits = @"[0-9]";

                    Regex regexDigits = new Regex(patternDigits);

                    MatchCollection matchesDigits = regexDigits.Matches(input);

                    int distance = 0;

                    foreach (Match match in matchesDigits)
                    {
                        distance += int.Parse(match.Value);
                    }


                    if (!participants.ContainsKey(nameOfParticipant))
                    {
                        participants.Add(nameOfParticipant, distance);
                    }
                    else
                    {
                        participants[nameOfParticipant] += distance;
                    }
                }

                input = Console.ReadLine();
            }


            var theWinners = participants.OrderByDescending(p => p.Value).Take(3);

            var theFirst = theWinners.OrderByDescending(p => p.Value).Take(1);
            var theSecond = theWinners.OrderByDescending(p => p.Value).Take(2).OrderBy(p => p.Value).Take(1);
            var theThird = theWinners.OrderByDescending(p => p.Value).OrderBy(p => p.Value).Take(1);

            foreach (var participant in theFirst)
            {
                Console.WriteLine($"1st place: {participant.Key}");
            }

            foreach (var participant in theSecond)
            {
                Console.WriteLine($"2nd place: {participant.Key}");
            }

            foreach (var participant in theThird)
            {
                Console.WriteLine($"3rd place: {participant.Key}");
            }
        }
    }
}
