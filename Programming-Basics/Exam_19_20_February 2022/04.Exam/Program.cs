using System;

namespace _04.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine()); //броя на студентите явили се на изпит
            

            double group1 = 0; //1.Група 1 - студенти с оценка >= 5.00
            double group2 = 0; //2.Група 2 - студенти с оценка >= 4 и <= 4.99
            double group3 = 0; //3.Група 3 - студенти с оценка >= 3 и <= 3.99
            double group4 = 0; //4.Група 4 - студенти с оценка < 3

            double sumGrades = 0.0;


            for (int student = 1; student <= students; student++)
            {
                double grade = double.Parse(Console.ReadLine()); //За всеки един студент на отделен ред – оценката от изпита
                sumGrades += grade;

                if (grade < 3)
                {
                    group4++;
                }
                else if (grade < 4)
                {
                    group3++;
                }
                else if (grade < 5)
                {
                    group2++;
                }
                else
                {
                    group1++;
                }
            }

            Console.WriteLine($"Top students: {group1 / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {group2 / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {group3 / students * 100:f2}%");
            Console.WriteLine($"Fail: {group4 / students * 100:f2}%");
            Console.WriteLine($"Average: {sumGrades / students:f2}");

        }
    }
}
