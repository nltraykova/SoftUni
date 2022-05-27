using System;

namespace _02.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); //Цена на моминското парти - реално число в интервала[1.00 … 10000.00]
            int loveMessages = int.Parse(Console.ReadLine()); //Брой любовни послания - цяло число в интервала[0… 1000]
            int roses = int.Parse(Console.ReadLine()); //Брой восъчни рози -цяло число в интервала[0 … 1000]
            int keyholders = int.Parse(Console.ReadLine()); //Брой ключодържатели - цяло число в интервала[0 … 1000]
            int cartoons = int.Parse(Console.ReadLine()); //Брой карикатури - цяло число в интервала[0 … 1000]
            int lucks = int.Parse(Console.ReadLine()); //Брой късмети изненада -цяло число в интервала[0 … 1000]


            double loveMessagesPrice = loveMessages * 0.6;
            double rosesPrice = roses * 7.2;
            double keyholdersPrice = keyholders * 3.6;
            double cartoonsPrice = cartoons * 18.2;
            double lucksPrice = lucks * 22;

            int sum = loveMessages + roses + keyholders + cartoons + +lucks;
            double totalPrice = loveMessagesPrice + rosesPrice + keyholdersPrice + cartoonsPrice + lucksPrice;

            if (sum >= 25)
            {
                totalPrice -= totalPrice * 0.35;
            }

            totalPrice -= totalPrice * 0.1;

            if (totalPrice >= budget)
            {
                Console.WriteLine($"Yes! {totalPrice - budget:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {budget - totalPrice:f2} lv needed.");
            }

        }
    }
}
