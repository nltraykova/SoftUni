using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstString = input[0];
            string secondString = input[1];


            Console.WriteLine(MultiplyCharacters(firstString, secondString));

        }

        static int MultiplyCharacters(string firstString, string secondString)
        {
            string shortestString = String.Empty;
            string longestString = String.Empty;
            int sum = 0;

            if (firstString.Length > secondString.Length)
            {
                longestString = firstString;
                shortestString = secondString;
            }
            else
            {
                shortestString = firstString;
                longestString = secondString;
            }

            for (int i = 0; i < shortestString.Length; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            for (int i = shortestString.Length; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }

            return sum;
        }
    }

    
}
