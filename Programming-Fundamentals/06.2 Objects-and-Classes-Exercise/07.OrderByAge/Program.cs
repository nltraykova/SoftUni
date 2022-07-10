using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] personProperties = input.Split().ToArray();

                string name = personProperties[0];
                string id = personProperties[1];
                int age = int.Parse(personProperties[2]);

                Person person = new Person(name, id, age);


                if (persons.Any(person => person.Id == id))
                {
                   person = persons.Find(person => person.Id == id);
                    person.Name = name;
                    person.Age = age;
                }
                else
                {
                    persons.Add(person);
                }

                input = Console.ReadLine();
            }

            foreach (var person in persons.OrderBy(person => person.Age))
            {
                Console.WriteLine(person);
            }

        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
       
    }
}
