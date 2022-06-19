using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringText = Console.ReadLine();

            CharactersInMiddle(stringText);
        }

        static void CharactersInMiddle(string stringText)
        {
            if (stringText.Length % 2 == 0)
            {
                Console.WriteLine($"{stringText[stringText.Length / 2 - 1]}{stringText[stringText.Length / 2]}");
            }
            else
            {
                Console.WriteLine(stringText[stringText.Length / 2]);
            }
        }
    }
}
