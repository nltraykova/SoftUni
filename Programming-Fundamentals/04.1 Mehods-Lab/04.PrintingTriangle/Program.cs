using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }


            for (int j = height - 1; j > 0; j--)
            {
                PrintLine(1, j);
                Console.WriteLine();
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }


        }
    }
}
