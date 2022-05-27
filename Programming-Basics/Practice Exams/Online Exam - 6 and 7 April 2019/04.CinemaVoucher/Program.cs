using System;

namespace _04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int vaucher = int.Parse(Console.ReadLine()); //стойност на ваучера

            string input = Console.ReadLine(); //име на покупката или команда "End" 

            int price = 0; //цена на покупката 

            int countTickets = 0; // брой закупени билети за кино

            int countOthers = 0; // брой закупени други покупик
        

            while (input != "End")
            {

                if (input.Length > 8)
                {
                    price = input[0] + input[1]; 
                    if (price > vaucher)
                    {
                        break;
                    }
                    countTickets++;
                }
                else
                {
                    price = input[0];
                    if (price > vaucher)
                    {
                        break;
                    }
                    countOthers++;
                }

                vaucher -= price; 

                input = Console.ReadLine();
            }

            if (input == "End" || price > vaucher)
            {
                Console.WriteLine(countTickets);
                Console.WriteLine(countOthers);
            }
        }
    }
}
