using System;

namespace _05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //име на играч или командата "End"
            int goals = 0; //броя голове
            
            int goalsMax = int.MinValue; ///най-голям брой вкарани голове

            string bestFootballer = string.Empty;
            string bestFootballerHatTrick = string.Empty;

            while (input != "END")
            {
                goals = int.Parse(Console.ReadLine()); //брой вкарани голове

                if (goals > goalsMax)
                {
                    goalsMax = goals;
                    bestFootballer = input;
                }
                
                if (goals >= 3)
                {
                    bestFootballerHatTrick = input;
                }
                
                if (goals >= 10)
                {
                    break;
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"{bestFootballer} is the best player!");
            
            
            if (bestFootballer == bestFootballerHatTrick)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goalsMax} goals.");
            }
        }
    }
}
