using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentProperties = input.Split().ToArray();

                string firstName = studentProperties[0];
                string lastName = studentProperties[1];
                int age = int.Parse(studentProperties[2]);
                string homeTown = studentProperties[3];


                if (IsStudentExists(listOfStudents, firstName, lastName))
                {
                    Student student = GetStudent(listOfStudents, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);

                    listOfStudents.Add(student);
                }
                
                input = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (var student in listOfStudents)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }


        static bool IsStudentExists(List<Student> listOfStudents, string firstName, string lastName)
        {
            foreach (var student in listOfStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> listOfStudents, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (var student in listOfStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}

class Student
{
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.HomeTown = homeTown;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}
