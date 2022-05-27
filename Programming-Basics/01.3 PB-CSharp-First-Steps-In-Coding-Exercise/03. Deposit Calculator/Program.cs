using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double finalSum = deposit + depositTerm * ((deposit * (annualInterestRate / 100)) / 12);

            Console.WriteLine(finalSum);
        }
    }
}
