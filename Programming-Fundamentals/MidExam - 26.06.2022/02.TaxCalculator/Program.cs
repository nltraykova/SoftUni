using System;
using System.Linq;

namespace _02.TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vehiclesList = Console.ReadLine().Split(">>").ToArray();

            double totalTaxCollected = 0.0;

            for (int i = 0; i < vehiclesList.Length; i++)
            {
                string[] currVehicle = vehiclesList[i].Split().ToArray();

                string carType = currVehicle[0];
                int yearsToTax = int.Parse(currVehicle[1]);
                int kilometers = int.Parse(currVehicle[2]);

                double taxToPay = 0.0;

                switch (carType)
                {
                    case"family":
                        taxToPay = (50 - yearsToTax * 5) + (kilometers / 3000) * 12;
                        totalTaxCollected += taxToPay;

                        Console.WriteLine($"A {carType} car will pay {taxToPay:f2} euros in taxes.");

                        break;
                    case "heavyDuty":
                        taxToPay = (80 - yearsToTax * 8) + (kilometers / 9000) * 14;
                        totalTaxCollected += taxToPay;

                        Console.WriteLine($"A {carType} car will pay {taxToPay:f2} euros in taxes.");
                        break;
                    case "sports":
                        taxToPay = (100 - yearsToTax * 9) + (kilometers / 2000) * 18;
                        totalTaxCollected += taxToPay;

                        Console.WriteLine($"A {carType} car will pay {taxToPay:f2} euros in taxes.");
                        break;
                    default:

                        Console.WriteLine("Invalid car type.");

                        break;
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {totalTaxCollected:f2} euros in taxes.");
        }
    }
}
