using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int numberOfAssessors = int.Parse(Console.ReadLine());
            double pointsTotal = pointsAcademy;

            for (int i = 1; i <= numberOfAssessors; i++)
            {
                string assessorName = Console.ReadLine();
                double pointsAssessor = double.Parse(Console.ReadLine());

                pointsTotal += assessorName.Length * pointsAssessor / 2;

                if (pointsTotal > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsTotal:F1}!");
                    break;
                }
            }
            if (pointsTotal <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - pointsTotal:F1} more!");
            }
        }
    }
}
