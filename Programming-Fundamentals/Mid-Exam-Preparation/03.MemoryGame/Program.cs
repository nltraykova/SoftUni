using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();
            int countMoves = 0;

            while (input != "end")
            {
                if (elements.Count == 0)
                {
                    break;
                }
                
                int[] indexes = input.Split().Select(int.Parse).ToArray();

                int firstIndex = indexes[0];
                int secondIndex = indexes[1];

                countMoves++;

                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex >= elements.Count || secondIndex < 0 || secondIndex >= elements.Count)
                {
                    elements.Insert(elements.Count / 2, $"-{countMoves}a");
                    elements.Insert(elements.Count / 2, $"-{countMoves}a");
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");

                        string elementToRemove = elements[firstIndex];

                        elements.RemoveAll(element => element == elementToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                input = Console.ReadLine();
            }

            if (elements.Count == 0)
            {
                Console.WriteLine($"You have won in {countMoves} turns!");
            }
            else
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(' ', elements));
            }
          
        }
    }
}
