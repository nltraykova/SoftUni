using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!IsValidNumberOfCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!IsEnoughNumberOfDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (IsValidNumberOfCharacters(password) && IsOnlyLettersAndDigits(password) && IsEnoughNumberOfDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsEnoughNumberOfDigits(string password)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }

            return true;
        }

        static bool IsOnlyLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            
            return true;
        }

        static bool IsValidNumberOfCharacters(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }

            return true;
        }
    }
}
