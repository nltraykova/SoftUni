using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._DegustationParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestsLikedMeals = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> guestsDislikedMeals = new Dictionary<string, List<string>>();

            int disLikedMeals = 0;

            
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                string guest = tokens[1];
                string meal = tokens[2];

                switch (cmd)
                {
                    case "Like":

                        if (!guestsLikedMeals.ContainsKey(guest) && !guestsDislikedMeals.ContainsKey (guest))
                        {
                            guestsLikedMeals.Add(guest, new List<string>());
                        }

                        guestsLikedMeals[guest].Add(meal);

                        break;
                    case "Dislike":

                        if (!guestsLikedMeals.ContainsKey(guest) && !guestsDislikedMeals.ContainsKey(guest))
                        {
                            Console.WriteLine($"{guest} is not at the party.");
                        }
                        else
                        {
                            if (guestsLikedMeals[guest].Contains(meal))
                            {
                                guestsLikedMeals[guest].Remove(meal);

                                Console.WriteLine($"{guest} doesn't like the {meal}.");
                                disLikedMeals++;
                            }
                            else
                            {
                                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                            }

                        }

                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var guest in guestsLikedMeals)
            {
                Console.Write($"{guest.Key}: ");
                Console.WriteLine(string.Join(", ", guest.Value));
            }

            Console.WriteLine($"Unliked meals: {disLikedMeals}");

        }
    }
}
