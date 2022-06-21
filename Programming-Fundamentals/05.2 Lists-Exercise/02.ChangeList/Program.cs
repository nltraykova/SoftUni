using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "Delete":
                        int elementToDelete = int.Parse(tokens[1]);
                        nums.RemoveAll(el => el == elementToDelete);
                        break;
                    case "Insert":
                        int elementToInsert = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        nums.Insert(position, elementToInsert);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
