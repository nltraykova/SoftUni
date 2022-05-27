using System;

namespace _01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double racketPrice = double.Parse(Console.ReadLine()); //Цена на една тенис ракета – реално число в интервала[0.00…100000.00]
            int racketCount = int.Parse(Console.ReadLine()); //Брой тенис ракети - цяло число в интервала[0…100]
            int shoesCount = int.Parse(Console.ReadLine()); // Брой чифтове маратонки -цяло число в интервала[0…100]

            double shoesPrice = racketPrice / 6; //Цена на един чифт маратонки - 1/6 от цената на една тенис ракета

            double price = racketCount * racketPrice + shoesCount * shoesPrice; //цена на закупените тенис ракети и маратонки
            
            double equipmentPrice = price * 0.2; //Цена на друга eкипировка - 20% от общата цена на закупените ракети и маратонки

            double totalPrice = price + equipmentPrice; //Обща цена на екипировката - тенис ракета, обувки и друга екипировка

            
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPrice /8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPrice * 7 / 8)}");

        }
    }
}
