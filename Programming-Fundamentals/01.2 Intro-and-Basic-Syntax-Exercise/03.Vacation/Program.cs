using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine(); //Students, Business or Regular
            string dayOfWeek = Console.ReadLine(); //Friday, Saturday or Sunday

            double price = 0.0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        price = countOfPeople * 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = countOfPeople * 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = countOfPeople * 10.46;
                    }

                    if (countOfPeople >= 30)
                    {
                        price -= price * 0.15;
                    }

                    break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        price = countOfPeople * 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = countOfPeople * 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = countOfPeople * 16.00;
                    }

                    if (countOfPeople >= 100)
                    {
                        price -= (price / countOfPeople) * 10;
                    }

                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        price = countOfPeople * 15.00;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = countOfPeople * 20.00;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = countOfPeople * 22.50;
                    }

                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        price -= price * 0.05;
                    }

                    break;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
