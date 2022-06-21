using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split().ToArray();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(index, numberToInsert);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(tokens[1]);
                        if (indexToRemove < 0 || indexToRemove >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Shift":
                        string direction = tokens[1];
                        int count = int.Parse(tokens[2]);
                        ShiftNumbers(direction, count, numbers);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        static void ShiftNumbers(string direction, int count, List<int> numbers)
        {
            if (direction == "left")
            {
                for (int i = 1; i <= count; i++)
                {
                    int currNumber = numbers[0];
                    numbers.Add(currNumber);
                    numbers.RemoveAt(0);
                }
            }
            else if (direction == "right")
            {
                for (int i = 1; i <= count; i++)
                {
                    int currNumber = numbers[numbers.Count-1];
                    numbers.Insert(0, currNumber);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
    }
}
