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

                Student student = new Student(studentProperties[0], studentProperties[1], int.Parse(studentProperties[2]), studentProperties[3]);

                listOfStudents.Add(student);

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
