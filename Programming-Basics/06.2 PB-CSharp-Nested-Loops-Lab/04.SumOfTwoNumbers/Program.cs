using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numStop = int.Parse(Console.ReadLine());
            int numMagic = int.Parse(Console.ReadLine());
            int counter = 0;
            
            
            for (int i = numStart; i <= numStop; i++)
            {
                for (int j = numStart; j <= numStop; j++)
                {
                    counter++;

                    if (i + j == numMagic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {numMagic})");

                        return;
                    }
                }
            }
          
                Console.WriteLine($"{counter} combinations - neither equals {numMagic}");
        }
    }
}
