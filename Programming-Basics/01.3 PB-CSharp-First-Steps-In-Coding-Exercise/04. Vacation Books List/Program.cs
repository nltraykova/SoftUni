using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPages = int.Parse(Console.ReadLine());
            int PagesPerHour = int.Parse(Console.ReadLine());
            int countDays = int.Parse(Console.ReadLine());

            int HoursPerDay = (countPages / PagesPerHour) / countDays;

            Console.WriteLine(HoursPerDay);
        }
    }
}
