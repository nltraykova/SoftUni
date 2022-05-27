using System;

namespace _05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); //Бюджет - реално  число в интервала[10.0… 100.0]
            int series = int.Parse(Console.ReadLine()); //Брой сериали -n - цяло положително число в интервала[1… 10]

            double seriePrice = 0.0; //цената на един сериал
            double seriePricesSum = 0.0; //сборът от цените на сериалите


            for (int serie = 1; serie <= series; serie++)
            {
                string serieName = Console.ReadLine();  //Име на сериал -текст
                seriePrice = double.Parse(Console.ReadLine()); //Цена за сериал -реално  число в интервала[1.0… 15.0]

                switch (serieName)
                {
                    case "Thrones":
                        seriePrice -= seriePrice * 0.5;
                        break;
                    case "Lucifer":
                        seriePrice -= seriePrice * 0.4;
                        break;
                    case "Protector":
                        seriePrice -= seriePrice * 0.3;
                        break;
                    case "TotalDrama":
                        seriePrice -= seriePrice * 0.2;
                        break;
                    case "Area":
                        seriePrice -= seriePrice * 0.1;
                        break;
                }

                seriePricesSum += seriePrice;
            }


            if (budget >= seriePricesSum)
            {
                Console.WriteLine($"You bought all the series and left with {budget - seriePricesSum:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {seriePricesSum - budget:f2} lv. more to buy the series!");
            }

        }
    }
}
