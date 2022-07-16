using System;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            string concatenatedString = string.Empty;

            foreach (var str in arr)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    concatenatedString += str;
                }
            }

            Console.WriteLine(concatenatedString);
        }
    }
}
