using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            CharactersInRange(char1, char2);
        }

        static void CharactersInRange(char char1, char char2) 
        {
            int startChar = Math.Min(char1, char2);
            int endChar = Math.Max(char1, char2);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
