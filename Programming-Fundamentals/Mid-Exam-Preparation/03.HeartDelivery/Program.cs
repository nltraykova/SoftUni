using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split('@').Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int currPosition = 0;
            int countSuccess = 0;
            

            while (command != "Love!")
            {
                string[] tokens = command.Split().ToArray();

                string cmd = tokens[0];
                int lenght = int.Parse(tokens[1]);

                if ((currPosition + lenght) >= houses.Length)
                {
                    currPosition = 0;
                }
                else
                {
                    currPosition += lenght;
                }
                

                if (houses[currPosition] == 0)
                {
                    Console.WriteLine($"Place {currPosition} already had Valentine's day.");
                }
                else
                {
                    houses[currPosition] -= 2;
                    if (houses[currPosition] <= 0)
                    {
                        Console.WriteLine($"Place {currPosition} has Valentine's day.");
                        countSuccess++;
                    }
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currPosition}.");

            int countFailed = houses.Length - countSuccess;
            
            if (countFailed == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {countFailed} places.");
            }
        }
    }
}
