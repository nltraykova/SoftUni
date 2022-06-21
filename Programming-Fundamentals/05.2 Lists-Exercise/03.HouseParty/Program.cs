using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<string> listOfGuests = new List<string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                string cmd = input[2];

                if (cmd == "going!" && !listOfGuests.Contains(name))
                {
                    listOfGuests.Add(name);
                }
                else if (cmd == "going!" && listOfGuests.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if (cmd == "not" && listOfGuests.Contains(name))
                {
                    listOfGuests.Remove(name);
                }
                else if ((cmd == "not" && !listOfGuests.Contains(name)))
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }

            foreach (var guest in listOfGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
