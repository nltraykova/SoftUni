using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> targetedCities = new Dictionary<string, int[]>();
            
            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] infoCities = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string cityName = infoCities[0];
                int people = int.Parse(infoCities[1]);
                int gold = int.Parse(infoCities[2]);
                
                
                if (targetedCities.ContainsKey(cityName))
                {
                    targetedCities[cityName][0] += people;
                    targetedCities[cityName][1] += gold;
                }
                else
                {
                    targetedCities.Add(cityName, new int[] { people, gold });
                }

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();
            
            while (commands != "End")
            {
                string[] tokens = commands.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Plunder":
                        Plunder(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), targetedCities);
                        break;
                    case "Prosper":
                        Prosper(tokens[1], int.Parse(tokens[2]), targetedCities);
                        break;
                }



                commands = Console.ReadLine();
            }

            if (targetedCities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {targetedCities.Count} wealthy settlements to go to:");

                foreach (var city in targetedCities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    
        static void Plunder(string cityName, int people, int gold, Dictionary<string, int[]> targetedCities)
        {
            targetedCities[cityName][0] -= people;
            targetedCities[cityName][1] -= gold;

            Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

            if (targetedCities[cityName][0] <= 0 || targetedCities[cityName][1] <= 0)
            {
                targetedCities.Remove(cityName);
                Console.WriteLine($"{cityName} has been wiped off the map!");
            }
        }

        static void Prosper(string cityName, int gold, Dictionary<string, int[]> targetedCities)
        {
            if (gold < 0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
                return;
            }

            targetedCities[cityName][1] += gold;

            Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {targetedCities[cityName][1]} gold.");

        }

    }
}
