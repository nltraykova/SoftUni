using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double sum = 0.0;

                while (sum < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
