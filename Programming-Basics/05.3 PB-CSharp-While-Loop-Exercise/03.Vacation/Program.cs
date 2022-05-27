using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            string action = string.Empty;
            double actionSum = 0.0;
            
            int countDays = 0; //брояч на изминалите дни
            int countDaysSpend = 0; //брояч на дните, в които харчи

            while (availableMoney < priceExcursion)
            {
                action = Console.ReadLine();
                actionSum = double.Parse(Console.ReadLine());

                countDays++;

                if (action == "save")
                {
                    availableMoney += actionSum;
                    countDaysSpend = 0;
                }
                else if (action == "spend")
                {
                    availableMoney -= actionSum;
                    
                    if (availableMoney - actionSum < 0)
                    {
                        availableMoney = 0;
                    }

                    countDaysSpend++;

                    if (countDaysSpend == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(countDays);
                        break;
                    }
                }
            }

            if (availableMoney >= priceExcursion)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}
