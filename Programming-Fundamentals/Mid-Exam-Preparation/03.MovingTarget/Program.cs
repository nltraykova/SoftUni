using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split().ToArray();

                string cmd = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);

                
                switch (cmd)
                {
                    case "Shoot":
                        if (index < 0 || index >= targets.Count)
                        {
                            break;
                        }
                        else
                        {
                            targets[index] -= value;
                        }

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;
                    case "Add":
                        if (index < 0 || index >= targets.Count)
                        {
                            Console.WriteLine($"Invalid placement!");
                        }
                        else
                        {
                            targets.Insert(index, value);
                        }
                        break;
                    case "Strike":
                        int startIndex = index - value;
                        int endIndex = index + value;

                        if (startIndex < 0 || endIndex >= targets.Count)
                        {
                            Console.WriteLine($"Strike missed!");
                        }
                        else
                        {
                            targets.RemoveRange(startIndex, endIndex - startIndex + 1);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|', targets));
        }

    }
}
