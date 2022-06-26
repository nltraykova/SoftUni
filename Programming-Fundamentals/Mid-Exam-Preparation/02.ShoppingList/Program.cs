using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!').ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command.Split().ToArray();

                string cmd = tokens[0];
                string item = tokens[1];

                if (shoppingList.Contains(item)) //АКО СЕ СЪДЪРЖА
                {
                    switch (cmd)
                    {
                        case "Unnecessary":
                            shoppingList.Remove(item);
                            break;
                        case "Correct":
                            string newItem = tokens[2];
                            int index = shoppingList.FindIndex(i => i == item);
                            shoppingList.Insert(index, newItem);
                            shoppingList.RemoveAt(index + 1);
                            break;
                        case "Rearrange":
                            shoppingList.RemoveAll(i => i == item);
                            shoppingList.Add(item);
                            break;
                    }
                }
                else //АКО НЕ СЕ СЪДЪРЖА
                {
                    switch (cmd)
                    {
                        case "Urgent":
                            shoppingList.Insert(0, item);
                            break;
                    }
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));

        }
    }
}
