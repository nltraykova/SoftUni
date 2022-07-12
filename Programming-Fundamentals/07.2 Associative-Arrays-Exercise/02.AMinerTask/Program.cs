using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string item = Console.ReadLine();

            while (item != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (! resources.ContainsKey(item))
                {
                    resources.Add(item, 0);
                }

                resources[item] += quantity;

                item = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
