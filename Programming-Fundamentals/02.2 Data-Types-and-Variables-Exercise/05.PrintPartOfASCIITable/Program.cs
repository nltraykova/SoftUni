﻿using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCharIndex = int.Parse(Console.ReadLine());
            int lastCharIndex = int.Parse(Console.ReadLine());

            for (int i = firstCharIndex; i <= lastCharIndex; i++)
            {
                Console.Write($"{(char)(i)} ");
            }
            
        }
    }
}
