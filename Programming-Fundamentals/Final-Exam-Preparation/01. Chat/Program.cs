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
                        Console.WriteLine(message);

                        break;
                    case "Reverse":

                        if (message.Contains(tokens[1]))
                        {
                            message = Reverse(tokens[1], message);
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    case "ChangeAll":

                        message = ChangeAll(tokens[1], tokens[2], message);
                        Console.WriteLine(message);

                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }

     
        static string InsertSpace(int index, string message) => message.Insert(index, " ");

        static string Reverse(string substring, string message)
        {
            int startIndex = message.IndexOf(substring);
            message = message.Remove(startIndex, substring.Length);

            string reversedSubstring = String.Empty;

            for (int i = substring.Length - 1; i >= 0; i--)
            {
                reversedSubstring += substring[i];
            }

            message += reversedSubstring;

            return message;
        }

        static string ChangeAll(string substring, string replacement, string message) => message.Replace(substring, replacement);
        
    }
}
