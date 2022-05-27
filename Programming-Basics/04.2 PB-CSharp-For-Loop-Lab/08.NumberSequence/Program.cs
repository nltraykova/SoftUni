using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numMax = int.MinValue;
            int numMin = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); //5, 7
                
                if (num > numMax)
                {
                    numMax = num;
                }

                if (num < numMin)
                {
                    numMin = num;
                }
            }
            Console.WriteLine($"Max number: {numMax}");
            Console.WriteLine($"Min number: {numMin}");
        }
    }
}
