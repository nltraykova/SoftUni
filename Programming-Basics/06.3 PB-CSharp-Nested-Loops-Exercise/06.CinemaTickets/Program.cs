using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //име на филм или командата "Finish"
            int freePlaces; //сбоводни места в залата за всеки филм
            int busyPlaces; //брой заети места в залата

            string input2 = string.Empty; //тип на закупения билет - "student", "standard", "kid" или командата "End"
            
            int studentTickets = 0; //брой на билетите от тип "student"
            int standardTickets = 0; //брой на билетите от тип "standard"
            int kidTickets = 0; //брой на билетите от тип "kid"

            double ticketsSum; //сума на закупените билет за дадения филм
            double totalTicketsSum = 0.0; //сума на закупените билет за дадения филм


            while (input != "Finish")
            {
                freePlaces = int.Parse(Console.ReadLine());

                ticketsSum = 0;
                busyPlaces = 0;

                input2 = Console.ReadLine();

                while (input2 != "End")
                {
                    switch (input2)
                    {
                        case"student":
                            studentTickets++;
                            ticketsSum++;
                            busyPlaces++;
                            break;
                        case "standard":
                            standardTickets++;
                            ticketsSum++;
                            busyPlaces++;
                            break;
                        case "kid":
                            kidTickets++;
                            ticketsSum++;
                            busyPlaces++;
                            break;
                    }

                    if (busyPlaces >= freePlaces)
                    {
                        break;
                    }

                    input2 = Console.ReadLine();
                }


                Console.WriteLine($"{input} - {(ticketsSum / freePlaces) * 100:f2}% full.");


                totalTicketsSum += ticketsSum;
                
              
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsSum}");
            Console.WriteLine($"{studentTickets / totalTicketsSum * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets / totalTicketsSum * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets / totalTicketsSum * 100:f2}% kids tickets.");
        }
    }
}
