using System;
using System.Collections.Generic;

namespace _03._HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            
            int numberOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroesProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroesProperties[0];
                int hitPoints = int.Parse(heroesProperties[1]);
                int manaPoints = int.Parse(heroesProperties[2]);

                heroes.Add(heroName, new int[] { hitPoints, manaPoints });
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "CastSpell":
                        CastSpell(tokens[1], int.Parse(tokens[2]), tokens[3], heroes);
                        break;
                    case "TakeDamage":
                        TakeDamage(tokens[1], int.Parse(tokens[2]), tokens[3], heroes);
                        break;
                    case "Recharge":
                        Recharge(tokens[1], int.Parse(tokens[2]), heroes);
                        break;
                    case "Heal":
                        Heal(tokens[1], int.Parse(tokens[2]), heroes);
                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }

        static void CastSpell(string heroName, int manaPointsNeeded, string spellName, Dictionary<string, int[]> heroes)
        {
            if (heroes[heroName][1] >= manaPointsNeeded)
            {
                heroes[heroName][1] -= manaPointsNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }

        static void TakeDamage(string heroName, int damage, string attacker, Dictionary<string, int[]> heroes)
        {
            heroes[heroName][0] -= damage;

            if (heroes[heroName][0] > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
            }
            else
            {
                heroes.Remove(heroName);
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
            }
        }

        static void Recharge(string heroName, int amount, Dictionary<string, int[]> heroes)
        {
            int currManaPoints = heroes[heroName][1];

            heroes[heroName][1] += amount;

            if (heroes[heroName][1] > 200)
            {
                heroes[heroName][1] = 200;
            }

            Console.WriteLine($"{heroName} recharged for {heroes[heroName][1] - currManaPoints} MP!");
        }

        static void Heal(string heroName, int amount, Dictionary<string, int[]> heroes)
        {
            int currHitPoints = heroes[heroName][0];

            heroes[heroName][0] += amount;

            if (heroes[heroName][0] > 100)
            {
                heroes[heroName][0] = 100;
            }

            Console.WriteLine($"{heroName} healed for {heroes[heroName][0] - currHitPoints} HP!");
        }
    }
}
