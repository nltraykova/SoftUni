using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //2
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= n*2; i++) //2*2 = 2 - цикълът ще се изпълнява четири пъти
            {
                int num = int.Parse(Console.ReadLine()); //5, 7, 6, 4

                if (i <= n) //true => 1 <= 2; true => 2 <= 2; false => 3 <= 2, false => 4 <= 2
                {
                    sum1 += num; //sum1 = 0 + 5 = 5, sum1 = 5 + 7 = 12
                }
                else 
                {
                    sum2 += num; //sum2 = 0 + 6 = 6,  sum2 = 6 + 4 = 10
                }
            }
            if (sum1 == sum2) //false => 12 = 10
            {
                Console.WriteLine($"Yes, sum = {sum1}"); 
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}"); // 12 - 10 = 2
            }
        }
    }
}
