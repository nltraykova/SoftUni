using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //броя на журито
            string input = Console.ReadLine(); //името на презентацията или команда "Finish"

            
            double presentationGrade; //средна оценка от всяка презентация
            double grades = 0.0; //сума от средните оценки от всяка презентация
            int presentationSum = 0; //брой на презентациите

            
            while (input != "Finish")
            {
                presentationGrade = 0.0;

                for (int i = 1; i <= n; i++)
                {
                    presentationGrade += double.Parse(Console.ReadLine());
                }

                presentationGrade = presentationGrade / n;

                Console.WriteLine($"{input} - {presentationGrade:f2}.");

                grades += presentationGrade;

                presentationSum++;

                input = Console.ReadLine();
            }

            
            Console.WriteLine($"Student's final assessment is {grades/presentationSum:f2}.");
        }
    }
}
