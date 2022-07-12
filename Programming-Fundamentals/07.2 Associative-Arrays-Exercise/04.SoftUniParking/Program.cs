using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string cmd = tokens[0];
                string userName = tokens[1];
                string licensePlateNumber = String.Empty;

                switch (cmd)
                {
                    case "register":
                        
                        licensePlateNumber = tokens[2];
                        
                        if (IfUserNameNotExist(registeredUsers, userName))
                        {
                            PrintResult($"{userName} registered {licensePlateNumber} successfully");
                            registeredUsers.Add(userName, licensePlateNumber);
                        }
                        else
                        {
                            PrintResult($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        break;
                    case "unregister":
                        if (IfUserNameNotExist(registeredUsers, userName))
                        {
                            PrintResult($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            PrintResult($"{userName} unregistered successfully");
                            registeredUsers.Remove(userName);
                        }
                        break;
                }
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

      
        static bool IfUserNameNotExist(Dictionary<string, string> registerdUsers, string userName)
        {
            if (! registerdUsers.ContainsKey(userName))
            {
                return true;
            }

            return false;
        }

        static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
