using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            string concatenatedString = ConcatenatedString(someString, num);

            Console.WriteLine(concatenatedString);
        }

        static string ConcatenatedString (string someString, int num)
        {
            string concatenatedString = String.Empty;

            for (int i = 0; i < num; i++)
            {
                concatenatedString += someString;
            }

            return concatenatedString;
        }
    }
}
