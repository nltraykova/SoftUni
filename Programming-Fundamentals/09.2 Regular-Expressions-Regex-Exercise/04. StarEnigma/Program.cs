using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _04._StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@(?<planet>[A-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>[A|D])![^@\-!:>]*->(?<count>\d+)";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();


            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfMessages; i++)
            {
                string encryptedMessage = Console.ReadLine(); 

                int count = encryptedMessage.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');

                string decryptedMessage = string.Empty;
                
                foreach (var symbol in encryptedMessage)
                {
                    decryptedMessage += (char)(symbol - count);
                }


                Regex regex = new Regex(pattern);

                Match match = regex.Match(decryptedMessage);

                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    char attackType = char.Parse(match.Groups["type"].Value);
                    int soldierCount = int.Parse(match.Groups["count"].Value);

                    if (attackType == 'A')
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }

            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
