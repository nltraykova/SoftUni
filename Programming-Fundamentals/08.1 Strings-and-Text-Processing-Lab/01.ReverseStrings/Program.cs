﻿using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> reversedWords = new Dictionary<string, string>();

            string text = Console.ReadLine();


            while (text != "end")
            {
                string reversedText = String.Empty;

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversedText += text[i];
                }

                reversedWords.Add(text, reversedText);

                text = Console.ReadLine();
            }

            foreach (var word in reversedWords)
            {
                Console.WriteLine($"{word.Key} = {word.Value}");
            }
        }
    }
}
