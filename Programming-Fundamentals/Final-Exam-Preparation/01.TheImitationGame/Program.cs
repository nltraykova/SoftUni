using System;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] tokens = input.Split('|');
                string command = tokens[0];

                switch (command)
                {
                    case "Move":

                        message = Move(message, tokens);

                        break;
                    case "Insert":

                        message = Insert(message, tokens);

                        break;
                    case "ChangeAll":

                        message = ChangeAll(message, tokens);

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }

     
        static string Move(string message, string[] tokens)
        {
            int lenght = int.Parse(tokens[1]);
            string stringToAdd = message.Substring(0, lenght);

            message = message.Remove(0, lenght);
            message += stringToAdd;
            
            return message;
        }

        static string Insert(string message, string[] tokens)
        {
            int startIndex = int.Parse(tokens[1]);
            string value = tokens[2];

            message = message.Insert(startIndex, value);
            
            return message;
        }

        private static string ChangeAll(string message, string[] tokens)
        {
            string oldValue = tokens[1];
            string newValue = tokens[2];

            message = message.Replace(oldValue, newValue);
            
            return message;
        }

    }
}
