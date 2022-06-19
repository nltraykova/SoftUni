using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // 56785

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input));

                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string input)
        {
            if (input.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
