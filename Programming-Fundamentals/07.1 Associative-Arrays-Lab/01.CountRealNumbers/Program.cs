using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> countOfOccurrencies = new SortedDictionary<double, int>();
            
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();


            foreach (var number in numbers)
            {
                if (! countOfOccurrencies.ContainsKey(number))
                {
                    countOfOccurrencies.Add(number, 0);
                }

                countOfOccurrencies[number]++;

            }

            foreach (var item in countOfOccurrencies)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
