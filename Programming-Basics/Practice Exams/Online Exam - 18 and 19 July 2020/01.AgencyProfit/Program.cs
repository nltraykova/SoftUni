using System;

namespace _01.AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); //име на авиокомпанията
            int adultTickets = int.Parse(Console.ReadLine()); //брой закупени билети за възрастни
            int childTickets = int.Parse(Console.ReadLine()); //брой закупени билети за зеца
            double adultTicketPrice = double.Parse(Console.ReadLine()); //цена на билет за възрастен
            double servicePrice = double.Parse(Console.ReadLine()); //такса обслужване

            double childTicketPrice = adultTicketPrice - adultTicketPrice * 0.7; //намираме цената на детския билет - 70% от този за възрастен

            childTicketPrice += servicePrice; //добавяме такса обслужване
            adultTicketPrice += servicePrice; //добавяме такса обслужване

            double totalPrice = adultTicketPrice * adultTickets + childTicketPrice * childTickets; //намираме общите приходи от продажба на билети 
            double profit = totalPrice * 0.2; //намираме печалбата -> 20% от общите приходи

            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");
        }
    }
}
