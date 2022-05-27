using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countSteps = 0;


            while (input != "Going home")
            {
                countSteps += int.Parse(input);
                
                if (countSteps >= 10000)
                {
                    break;
                }
                
                input = Console.ReadLine();
            }

            if (input == "Going home")
            {
                input = Console.ReadLine();
                countSteps += int.Parse(input);
            }

            if (countSteps < 10000)
            {
                Console.WriteLine($"{10000 - countSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{countSteps - 10000} steps over the goal!");
            }
        }
    }
}
