using System;

namespace _06.FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //име на филм или командата "STOP"
            int points; //броя точки за всеки филм
            int counter = 0; //броя на филмите

            string theBestFilm = string.Empty;
            int pointsMax = int.MinValue; //максимания брой точки
            
            while (input != "STOP")
            {
                points = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsUpper(input[i]))
                    {
                        points += input[i] - input.Length;
                    }
                    else if (Char.IsLower(input[i]))
                    {
                        points += input[i] - 2*input.Length;
                    }
                    else
                    {
                        points += input[i];
                    }
                }

                if (points > pointsMax)
                {
                    pointsMax = points;
                    theBestFilm = input;
                }


                counter++;

                if (counter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {theBestFilm} with {pointsMax} ASCII sum.");


        }
    }
}
