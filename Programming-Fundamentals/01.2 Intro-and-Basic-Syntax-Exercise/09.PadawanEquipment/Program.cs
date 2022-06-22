using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalPriceLightsaber = Math.Ceiling((countOfStudents + countOfStudents*0.1)) * priceOfLightsaber;
            double totalPriceRobes = countOfStudents * priceOfRobes;
            double totalPriceBelts = 0.00;
            
            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 != 0)
                {
                    totalPriceBelts += priceOfBelts;
                }
            }

            double totalSum = totalPriceLightsaber + totalPriceRobes + totalPriceBelts;

            if (amountOfMoney >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - amountOfMoney:f2}lv more.");
            }
           
        }
    }
}
