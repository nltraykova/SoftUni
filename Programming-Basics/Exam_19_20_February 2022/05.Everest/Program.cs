using System;

namespace _05.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // текст "Yes" / "No" или "END"
            
            int totalMeters = 5364; //общо изкачени метри
            int days = 1; //брой дни

            while (input != "END")
            {
                if (input == "No")
                {
                    days--;
                }

                int meters = int.Parse(Console.ReadLine()); //изкачени метри 
                days++;
               
                if (days > 5)
                {
                    break;
                }
                
                totalMeters += meters;
                
                if (totalMeters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    break;
                }

                input = Console.ReadLine();
            }

            
            if (input == "END" || days > 5)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{totalMeters}");
            }

        }
    }
}
