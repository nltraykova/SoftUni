using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _05._NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\d\-\+\.\/\*]";
            string damagePattern = @"-?\d+\.?\d*";
            string multiplyDividePattern = @"[\/\*]";
            string splitPattern = @"[,\s]+";

            string input = Console.ReadLine(); //M3ph-0.5s-0.5t0.0**,  Azazel

            string[] demons = Regex.Split(input, splitPattern); //M3ph-0.5s-0.5t0.0**, Azazel

            List<Demon> listOfDemons = new List<Demon>();


            for (int i = 0; i < demons.Length; i++)
            {
                string currDemon = demons[i]; //M3ph-0.5s-0.5t0.0**

                Regex regexHealth = new Regex(healthPattern);
                MatchCollection matchesHealth = regexHealth.Matches(currDemon); //Mphst

                int health = 0;


                foreach (Match ch in matchesHealth)
                {
                    health += char.Parse(ch.ToString());
                }


                Regex regexDamage = new Regex(damagePattern);
                MatchCollection matchesDamage = regexDamage.Matches(currDemon); //3 -0.5 -0.5 0.0

                double damage = 0.0;


                foreach (Match num in matchesDamage)
                {
                    damage += double.Parse(num.ToString());
                }


                Regex regexMultiplierDivider = new Regex(multiplyDividePattern);
                MatchCollection matchesMultiplierDivider = regexMultiplierDivider.Matches(currDemon); //**


                foreach (Match symbol in matchesMultiplierDivider)
                {
                    char currSymbol = char.Parse(symbol.ToString());

                    if (currSymbol == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                Demon demon = new Demon(currDemon, health, damage);

                listOfDemons.Add(demon);
            }

            if (listOfDemons.Count != 0)
            {
                foreach (var demon in listOfDemons.OrderBy(demon => demon.Name))
                {
                    Console.WriteLine(demon);
                }
            }
        }
    }

    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString() => $"{this.Name} - {this.Health} health, {this.Damage:f2} damage";
    }
}
