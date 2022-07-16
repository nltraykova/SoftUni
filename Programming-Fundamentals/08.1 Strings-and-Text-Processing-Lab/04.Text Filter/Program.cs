using System;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    string oldValue = word;
                    string newValue = new string('*', word.Length);

                    text = text.Replace(oldValue, newValue);
                }
            }

            Console.WriteLine(text);
        }
    }
}
