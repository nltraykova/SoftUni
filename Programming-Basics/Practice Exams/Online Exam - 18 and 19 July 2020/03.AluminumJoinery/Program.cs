using System;

namespace _03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int frames = int.Parse(Console.ReadLine()); // брой дограми
            string frameType = Console.ReadLine(); // вид на дограмите - "90X130" или "100X150" или "130X180" или "200X300"
            string deliveryType = Console.ReadLine(); // начин на получаване - "With delivery" или "Without delivery"

            double price = 0.0; //цена на дограмата

            if (frames < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            switch (frameType)
            {
                case "90X130":
                    
                    price = 110;

                    if (frames > 30 && frames <= 60)
                    {
                        price -= price * 0.05;
                    }
                    else if (frames > 60)
                    {
                        price -= price * 0.08;
                    }
                    break;

                case "100X150":

                    price = 140;

                    if (frames > 40 && frames <= 80)
                    {
                        price -= price * 0.06;
                    }
                    else if (frames > 80)
                    {
                        price -= price * 0.1;
                    }

                    break;
                case "130X180":

                    price = 190;

                    if (frames > 20 && frames <= 50)
                    {
                        price -= price * 0.07;
                    }
                    else if (frames > 50)
                    {
                        price -= price * 0.12;
                    }
                    break;
                case "200X300":

                    price = 250;

                    if (frames > 25 && frames <= 50)
                    {
                        price -= price * 0.09;
                    }
                    else if (frames > 50)
                    {
                        price -= price * 0.14;
                    }

                    break;
            }
            
            
            double totalPrice = frames * price;

            if (deliveryType == "With delivery")
            {
                totalPrice += 60;
            }

            if (frames > 99)
            {
                totalPrice -= totalPrice * 0.04;
            }
            
            Console.WriteLine($"{totalPrice:f2} BGN");
        }
    }
}
