using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            
            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(' ', numbers));
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        NumberToAdd(command[1], numbers);
                        break;
                    case "Remove":
                        NumberToRemove(command[1], numbers);
                        break;
                    case "RemoveAt":
                        NumberToRemoveAt(command[1], numbers);
                        break;
                    case "Insert":
                        NumberToInsert(command[1], command[2], numbers);
                        break;
                }
            }
        }

      
        static List<int> NumberToAdd(string command, List<int> numbers)
        {
            int numberToAdd = int.Parse(command);
            
            numbers.Add(numberToAdd);

            return numbers;
        }

        static List<int> NumberToRemove(string command, List<int> numbers)
        {
            int numberToRemove = int.Parse(command);

            numbers.Remove(numberToRemove);

            return numbers;
        }

        static List<int> NumberToRemoveAt(string command, List<int> numbers)
        {
            int index = int.Parse(command);

            numbers.RemoveAt(index);

            return numbers;
        }

        static List<int> NumberToInsert(string command, string command2, List<int> numbers)
        {
            int numberToInsert = int.Parse(command);
            int index = int.Parse(command2);

            numbers.Insert(index, numberToInsert);

            return numbers;
        }

    }
}
