using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersToString = Console.ReadLine().Split('|').Reverse().ToList();

            List<int> numbers = new List<int>();


            foreach (var numberToString in numbersToString)
            {
                numbers.AddRange(numberToString.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
