using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentProperties = Console.ReadLine().Split().ToArray();

                Student student = new Student(studentProperties[0], studentProperties[1], double.Parse(studentProperties[2]));

                students.Add(student);
            }

            foreach (var student in students.OrderByDescending(student => student.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString() => $"{this.FirstName} {this.LastName}: {this.Grade:f2}";

    }
}
