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

            bool isListChanged = false;

            while (true)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                
                if (command[0] == "end")
                {
                    if (isListChanged == true)
                    {
                        Console.WriteLine(string.Join(' ', numbers));
                    }
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        NumberToAdd(command[1], numbers);
                        isListChanged = true;
                        break;
                    case "Remove":
                        NumberToRemove(command[1], numbers);
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        NumberToRemoveAt(command[1], numbers);
                        isListChanged = true;
                        break;
                    case "Insert":
                        NumberToInsert(command[1], command[2], numbers);
                        isListChanged = true;
                        break;
                    case "Contains":
                        CheckContainNumber(command[1], numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "GetSum":
                        PrintGetSum(numbers);
                        break;
                    case "Filter":
                        PrintByFilter(command[1], command[2], numbers);
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

        static void CheckContainNumber(string command, List<int> numbers)
        {
            int numberToCheck = int.Parse(command);

            if (numbers.Contains(numberToCheck))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintOdd(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write($"{number} ");
                }
            }

            Console.WriteLine();
        }

        static void PrintEven(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
            }

            Console.WriteLine();
        }

        static void PrintGetSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        static void PrintByFilter(string filter, string command2, List<int> numbers)
        {
            int numberToFilter = int.Parse(command2);

            switch (filter)
            {
                case">":
                    foreach (var number in numbers)
                    {
                        if (number > numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<":
                    foreach (var number in numbers)
                    {
                        if (number < numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<=":
                    foreach (var number in numbers)
                    {
                        if (number <= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">=":
                    foreach (var number in numbers)
                    {
                        if (number >= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}
