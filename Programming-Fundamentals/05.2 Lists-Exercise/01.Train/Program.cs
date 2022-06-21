using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            
            while (input != "end")
            {
                string[] tokens = input.Split().ToArray();

                if (tokens.Length == 2)
                {
                    string command = tokens[0];
                    int passengersToAdd = int.Parse(tokens[1]);

                    wagons.Add(passengersToAdd);
                }
                else
                {
                    int passengersToAdd = int.Parse(tokens[0]);
                    WagonToAdd(passengersToAdd, wagons, maxCapacity);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }

        static void WagonToAdd(int passengersToAdd, List<int> wagons, int maxCapacity)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int currWagon = wagons[i];

                if (currWagon + passengersToAdd <= maxCapacity)
                {
                    wagons[i] += passengersToAdd;
                    break;
                }
            }
        }
    }
}
