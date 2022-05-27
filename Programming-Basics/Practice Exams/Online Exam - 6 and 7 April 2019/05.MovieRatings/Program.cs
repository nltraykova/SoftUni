using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int films = int.Parse(Console.ReadLine()); //броя филми, които си е набелязала да гледа

            string filmName = string.Empty;
            double rating = 0.0;

            double highestRating = double.MinValue;
            double lowestRating = double.MaxValue;
            double ratingsSum = 0.0;

            string filmHighestRating = string.Empty;
            string filmLowestRating = string.Empty;


            for (int film = 1; film <= films; film++)
            {
                filmName = Console.ReadLine();
                rating = double.Parse(Console.ReadLine());

                ratingsSum += rating;
                
                if (rating > highestRating)
                {
                    highestRating = rating;
                    filmHighestRating = filmName; 
                }
                else if (rating < lowestRating)
                {
                    lowestRating = rating;
                    filmLowestRating = filmName;
                }
            }

            double averageRating = ratingsSum / films;

            Console.WriteLine($"{filmHighestRating} is with highest rating: {highestRating:f1}");
            Console.WriteLine($"{filmLowestRating} is with lowest rating: {lowestRating:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");

        }
    }
}
