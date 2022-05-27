using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //3 - цикълът ще се изпълнява три пъти

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine()); //3, 2, 800

                if (num <= 199)
                {
                    p1++; //1, 2
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++; //1
                }
            }
            Console.WriteLine($"{p1 / n * 100:F2}%"); // 2 / 3 * 100 = 66.67%
            Console.WriteLine($"{p2 / n * 100:F2}%"); // 0.00%
            Console.WriteLine($"{p3 / n * 100:F2}%"); // 0.00%
            Console.WriteLine($"{p4 / n * 100:F2}%"); // 0.00%
            Console.WriteLine($"{p5 / n * 100:F2}%"); // 1 / 3 * 100 = 33.33%
        }
    }
}
