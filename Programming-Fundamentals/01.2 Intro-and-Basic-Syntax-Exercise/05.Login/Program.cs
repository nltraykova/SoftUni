using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            string input = Console.ReadLine();
            int count = 0;

            while (input != password)
            {
                count++;

                if (count == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                input = Console.ReadLine();
            }

            if (input == password)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
