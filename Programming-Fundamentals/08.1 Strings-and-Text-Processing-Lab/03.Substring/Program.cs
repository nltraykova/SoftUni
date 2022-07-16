using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine();
            string stringToManipulate = Console.ReadLine();

            while (stringToManipulate.Contains(stringToRemove))
            {
                int startIndex = stringToManipulate.IndexOf(stringToRemove);
                int count = stringToRemove.Length;

                stringToManipulate = stringToManipulate.Remove(startIndex, count);
            }

            Console.WriteLine(stringToManipulate);
        }
    }
}
