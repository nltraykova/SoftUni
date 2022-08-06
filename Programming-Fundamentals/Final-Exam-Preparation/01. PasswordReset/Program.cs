using System;

namespace _01._PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "TakeOdd":
                        password = TakeOdd(password);
                        break;
                    case "Cut":
                        password = Cut(int.Parse(tokens[1]), int.Parse(tokens[2]), password);
                        break;
                    case "Substitute":
                        password = Substitute(tokens[1], tokens[2], password);
                        break;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        static string TakeOdd(string password)
        {
            string newPassword = string.Empty;

            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPassword += password[i];
                }
            }

            Console.WriteLine(newPassword);
            
            return newPassword;
        }

        static string Cut(int index, int lenght, string password)
        {
            string substring = password.Substring(index, lenght);

            int startIndex = password.IndexOf(substring);

            password = password.Remove(startIndex, substring.Length);

            Console.WriteLine(password);

            return password;
        }

        static string Substitute(string substring, string substitute, string password)
        {
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");   
            }

            return password;
        }

    }
}
