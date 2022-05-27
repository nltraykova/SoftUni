using System;

namespace ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int time = numberOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {time} hours to complete {numberOfProjects} project/s.");

        }
    }
}
