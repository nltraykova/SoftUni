using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            

            for (int i = 1; i <= n; i++)
            {
                int lastDigit = i; //15
                int sum = 0;

                while (lastDigit != 0)
                {
                    sum += lastDigit % 10; //15 % 10 = 5; 0+5 = 5     1 % 10 = 1; 5+1 = 6-> вземаме последната цифра и я събираме я към общата сума
                    lastDigit = lastDigit / 10; // 15 / 10 = 1;    6 / 10 = 0 -> премахваме последната и вземаме следващата цифра
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False"); 
                }

            }
        }
    }
}
