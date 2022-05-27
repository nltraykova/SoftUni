using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //4
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= n; i++) //цикълът ще се изпълнява 4 пъти
            {
                int num = int.Parse(Console.ReadLine()); //5, 3, 8, 10

                if (i % 2 == 0) //false => 1 % 2, true => 2 % 2, false => 3 % 2, true => 4 % 2,
                {
                    sum1 += num; //sum1 = 0 + 3 = 3, sum1 = 3 + 10 = 13;
                }
                else
                {
                    sum2 += num; //sum2 = 0 + 5 = 5, sum2 = 5 + 8 = 13; 
                }
            }
            
            if (sum1 == sum2) //true => 13 = 13
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}"); //13
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
