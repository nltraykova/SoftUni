using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedCount = int.Parse(Console.ReadLine());
            string exerciseName = string.Empty;
            int exerciseGrade = 0;
            int exerciseCount = 0;
            double exerciseSum = 0;
            int count = 0; //брояч на незадоволителните оценки

            string input = Console.ReadLine();
            
            while (input != "Enough")
            {
                exerciseName = input;
                exerciseGrade = int.Parse(Console.ReadLine());
                exerciseCount++;
                exerciseSum += exerciseGrade;

                if (exerciseGrade <= 4)
                {
                    count++;
                    if (count == failedCount)
                    {
                        Console.WriteLine($"You need a break, {failedCount} poor grades."); 
                        break;
                    }
                }

                input = Console.ReadLine();
            }
            
            double averageGrade = exerciseSum / exerciseCount;


            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrade:F2}");
                Console.WriteLine($"Number of problems: {exerciseCount}");
                Console.WriteLine($"Last problem: {exerciseName}");
            }

        }
    }
}
