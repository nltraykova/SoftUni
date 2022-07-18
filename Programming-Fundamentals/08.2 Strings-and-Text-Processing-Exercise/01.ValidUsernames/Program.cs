using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUserNames = new List<string>();


            foreach (var userName in userNames)
            {
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    bool isValid = true;

                    foreach (var ch in userName)
                    {
                        if (!(char.IsLetterOrDigit(ch) || ch == '_' || ch == '-'))
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        validUserNames.Add(userName);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));

        }
    }
}
