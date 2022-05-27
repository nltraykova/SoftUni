﻿using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{currentNum} ");
                    currentNum++;

                    if (currentNum > n)
                    {
                        break;
                    }
                }
               
                if (currentNum > n)
                {
                    break;
                }

                Console.WriteLine();
            }

        }
    }
}
