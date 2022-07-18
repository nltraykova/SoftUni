using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder manipulatedInput = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    manipulatedInput.Append(input[i]);
                }
                else if (input[i] != input[i + 1])
                {
                    manipulatedInput.Append(input[i]);
                }
            }

            Console.WriteLine(manipulatedInput);
        }
    }
}
