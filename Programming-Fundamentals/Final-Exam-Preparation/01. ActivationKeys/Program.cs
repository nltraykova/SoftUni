using System;

namespace _01._ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Contains":
                        Contains(tokens[1], activationKey);
                        break;
                    case "Flip":
                        activationKey = Flip(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), activationKey);
                        break;
                    case "Slice":
                        activationKey = Slice(int.Parse(tokens[1]), int.Parse(tokens[2]), activationKey);
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }

        static void Contains(string substring, string activationKey)
        {
            if (activationKey.Contains(substring))
            {
                Console.WriteLine($"{activationKey} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }

        static string Flip(string upperOrLower, int startIndex, int endIndex, string activationKey)
        {
            string substringOld = activationKey.Substring(startIndex, endIndex - startIndex);

            if (upperOrLower == "Upper")
            {
                string substingNew = substringOld.ToUpper();

                activationKey = activationKey.Replace(substringOld, substingNew);
            }
            else
            {
                string substingNew = substringOld.ToLower();

                activationKey = activationKey.Replace(substringOld, substingNew);
            }

            Console.WriteLine(activationKey);

            return activationKey;
        }

        static string Slice(int startIndex, int endIndex, string activationKey)
        {
            activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(activationKey);

            return activationKey;
        }
    }
}
