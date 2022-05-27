using System;

namespace _06.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine()); //Горната граница на първото число - цяло число в диапазона[1...9]
            int num2 = int.Parse(Console.ReadLine()); //Горната граница на второто число - цяло число в диапазона[1...9]
            int num3 = int.Parse(Console.ReadLine());  //Горната граница на третото число - цяло число в диапазона[1...9]

          

            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                for (int j = 2; j <= num2; j++)
                {
                    bool isPrime = true;

                    for (int m = 2; m < (j-1); m++)
                    {
                        if (j % m == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime == false)
                    {
                        continue;
                    }

                    for (int k = 1; k <= num3; k++)
                    {
                        if (k % 2 != 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}
