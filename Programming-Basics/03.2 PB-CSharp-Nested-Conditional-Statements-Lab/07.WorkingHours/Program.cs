using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (h >= 10 && h <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
            }

        }
    }
}
