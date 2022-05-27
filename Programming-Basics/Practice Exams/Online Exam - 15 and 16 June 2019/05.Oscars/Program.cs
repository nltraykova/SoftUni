using System;

namespace _05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine(); //Име на актьора – текст
            double academyPoints = double.Parse(Console.ReadLine()); //Точки от академията - реално число в интервала[2.0... 450.5]
            int assessors = int.Parse(Console.ReadLine()); //Брой оценяващи n – цяло число в интервала[1… 20]

            double totalPoints = academyPoints;

            for (int assessor = 1; assessor <= assessors; assessor++)
            {
                string assessorName = Console.ReadLine(); //o Име на оценяващия – текст
                double assessorPoints = double.Parse(Console.ReadLine()); //o Точки от оценяващия – реално число в интервала[1.0... 50.0]

                double actorPoints = (assessorName.Length * assessorPoints) / 2;
                
                totalPoints += actorPoints;

                if (totalPoints > 1250.5)
                {
                    break;
                }
            }

            if (totalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}
