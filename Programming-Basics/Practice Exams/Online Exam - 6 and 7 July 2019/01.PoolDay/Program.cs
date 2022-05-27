using System;

namespace _01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()); // брой хора
            double entranceFee = double.Parse(Console.ReadLine()); // такста вход
            double priceLounge = double.Parse(Console.ReadLine()); //цена за 1 шезлонг
            double priceUmbrella = double.Parse(Console.ReadLine()); //цена за 1 чадър

            double totalEntranceFee = people * entranceFee;

            double umbrellaQty = Math.Ceiling(people / 2.0);
            double totalpriceUmbrella = umbrellaQty * priceUmbrella;

            double loungeQty = Math.Ceiling(people * 0.75);
            double totalpriceLounge = loungeQty * priceLounge;

            double totalSum = totalEntranceFee + totalpriceUmbrella + totalpriceLounge;

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
