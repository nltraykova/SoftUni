using System;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] tokens = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "InsertSpace":
                        message = InsertSpace(int.Parse(tokens[1]), message);
                        break;
                    case "Reverse":
                        message = Reverse(tokens[1], message);
                        break;
                    case "ChangeAll":
                        break;
                }

                Console.WriteLine(message);

                command = Console.ReadLine();
            }
        }

        static string InsertSpace(int index, string message) => message.Insert(index, " ");

        static string Reverse(string substring, string message)
        {
            if (message.Contains(substring))
            {
                int startIndex = message.IndexOf(substring);
                message = message.Remove(startIndex);
                message += substring;
            }

            return message;
        }


    }
}
