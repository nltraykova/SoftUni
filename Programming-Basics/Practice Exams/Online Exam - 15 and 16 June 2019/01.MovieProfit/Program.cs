using System;

namespace _01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine(); //1.Име на филм -текст
            int days = int.Parse(Console.ReadLine()); //2.Брой дни - цяло число в диапазона[1… 90]
            int tickets = int.Parse(Console.ReadLine());  //3.Брой билети - цяло число в диапазона[100… 100000]
            double ticketPrice = double.Parse(Console.ReadLine());  //4.Цена на билет - реално число в диапазона[5.0… 25.0]
            int percent = int.Parse(Console.ReadLine());  //5.Процент за киното - цяло число в диапазона[5... 35]

            double totalPrice = ticketPrice * tickets * days;

            double profit = totalPrice - totalPrice * (percent / 100.00);

            Console.WriteLine($"The profit from the movie {filmName} is {profit:f2} lv.");

        }
    }
}
