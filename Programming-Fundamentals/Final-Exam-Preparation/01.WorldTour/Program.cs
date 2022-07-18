using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] tokens = input.Split(':');
                string command = tokens[0];

                switch (command)
                {
                    case "Add Stop":

                        int index = int.Parse(tokens[1]);
                        string stringToInsert = tokens[2];
                        
                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, stringToInsert);
                        }

                        break;
                    case "Remove Stop":

                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        if (startIndex >= 0 
                            && startIndex < stops.Length 
                            && endIndex >= 0
                            && endIndex < stops.Length)
                        {
                            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                        }

                        break;
                    case "Switch":

                        string oldString = tokens[1];
                        string newString = tokens[2];

                        stops = stops.Replace(oldString, newString);

                        break;
                }

                Console.WriteLine(stops);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
