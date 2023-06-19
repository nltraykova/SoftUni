using System;

namespace _01._PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "Complete")
            {
                string[] tokens = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Make":
                        password = Make(tokens[1], int.Parse(tokens[2]), password);
                        break;
                    case "Insert":
                        password = Insert(int.Parse(tokens[1]), tokens[2], password);
                        break;
                    case "Replace":
                        password = Replace(char.Parse(tokens[1]), int.Parse(tokens[2]), password);
                        break;
                    case "Validation":
                        Validation(password);
                        break;
                    default:
                        commands = Console.ReadLine();
                        continue;
                }

                commands = Console.ReadLine();
            }
        }


        static string Make(string upperOrLower, int index, string password)
        {
            string substringLetter = password.Substring(index, 1);
            int indexOfsubstringLetter = password.IndexOf(substringLetter);

            password = password.Remove(index, 1);
            
            if (upperOrLower == "Upper")
            {
                substringLetter = substringLetter.ToUpper();
            }
            else
            {
                substringLetter = substringLetter.ToLower();
            }

            password = password.Insert(indexOfsubstringLetter, substringLetter);

            Console.WriteLine(password);

            return password;
        }

        static string Insert(int index, string ch, string password)
        {
            if (index >= 0 && index < password.Length)
            {
                password = password.Insert(index, ch);
                Console.WriteLine(password);
            }
            
            return password;
        }

        static string Replace(char ch, int value, string password)
        {
            if (password.Contains(ch))
            {
                string oldValue = ch.ToString();
                int newValueSum = ch + value; //181
                char newValueChar = (char)newValueSum;
                string newValue = newValueChar.ToString();
                
                password = password.Replace(oldValue, newValue);

                Console.WriteLine(password);
            }

            return password;
        }


        static void Validation(string password)
        {
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
            }

            foreach (var ch in password)
            {
                if (! char.IsLetterOrDigit(ch) && ch != '_')
                {
                    Console.WriteLine("Password must consist only of letters, digits and _!");
                    break;
                }
            }

            bool isValidA = false;
            
            foreach (var ch in password)
            {
                if (char.IsUpper(ch))
                {
                    isValidA = true;
                    break;
                }
            }

            if (isValidA == false)
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
            }


            bool isValidB = false;

            foreach (var ch in password)
            {
                if (char.IsLower(ch))
                {
                    isValidB = true;
                    break;
                }
            }

            if (isValidB == false)
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
            }


            bool isValidC = false;

            foreach (var ch in password)
            {
                if (char.IsDigit(ch))
                {
                    isValidC = true;
                    break;
                }
            }

            if (isValidC == false)
            {
                Console.WriteLine("Password must consist at least one digit!");
            }
        }

    }
}
