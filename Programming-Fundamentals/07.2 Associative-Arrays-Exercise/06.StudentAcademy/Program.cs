using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            const double MINIMUM_GRADE = 4.5;

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }

                students[studentName].Add(grade);
            }


            foreach (var student in students)
            {
                List<double> grades = student.Value;
                double averageGrade = grades.Average();

                if (averageGrade >= MINIMUM_GRADE)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
