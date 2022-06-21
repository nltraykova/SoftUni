using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] tokens = command.Split().ToArray();
                
                string cmd = tokens[0];
                
                switch (cmd)
                {
                    case "merge":

                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        if (startIndex < 0 || startIndex > myList.Count - 1)
                        {
                            startIndex = 0;
                        }

                        if (endIndex < 0 || endIndex > myList.Count - 1)
                        {
                            endIndex = myList.Count - 1;
                        }

                        string concatenatedWord = string.Empty;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatenatedWord += myList[i];
                        }
                        myList.RemoveRange(startIndex, endIndex - startIndex + 1);
                        myList.Insert(startIndex, concatenatedWord);
                        break;

                    case "divide":
                        int index = int.Parse(tokens[1]);
                        int partitons = int.Parse(tokens[2]);

                        List<string> dividedList = new List<string>();
                        string wordToDivide = myList[index];
                        myList.RemoveAt(index);
                        int parts = wordToDivide.Length / partitons;

                        for (int i = 0; i < partitons; i++)
                        {
                            if (i == partitons - 1)
                            {
                                dividedList.Add(wordToDivide.Substring(i * parts));
                            }
                            else
                            {
                                dividedList.Add(wordToDivide.Substring(i * parts, parts));
                            }
                        }
                        myList.InsertRange(index, dividedList);
                        break;

                }

                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(' ', myList));


        }
    }
}
