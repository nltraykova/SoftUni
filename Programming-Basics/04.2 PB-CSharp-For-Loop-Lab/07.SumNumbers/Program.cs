using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //2
            int sum = 0; 

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); //5, 7
                sum += num; //0+5, 5+7
            }
            Console.WriteLine(sum);
        }
    }
}
