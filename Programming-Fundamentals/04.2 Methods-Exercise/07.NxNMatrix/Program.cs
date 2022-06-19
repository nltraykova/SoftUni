using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            NxNMatrix(num);
        }

        static void NxNMatrix(int num)
        {
            for (int rows = 0; rows < num; rows++)
            {
                for (int columns = 0; columns < num; columns++)
                {
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }
        }
    }
}
