using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); //5
            int sum = 0;

            while (num > sum) //true -> 5 < 0; true -> 4 < 5
            {
                int num2 = int.Parse(Console.ReadLine()); //4, 1
                sum += num2; // 0+4=4; 4+1 = 5
            }
            
            Console.WriteLine(sum);
        }
    }
}
