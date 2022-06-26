using System;
using System.Linq;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            const int LIFT_CAPACITY = 4;

            bool isWagonFull = false;

            for (int i = 0; i < lift.Length; i++)
            {
                int emptySpots = 0;
                int peopleToAdd = 0;
                isWagonFull = false;

                if (people == 0)
                {
                    break;
                }
                
                if (lift[i] < LIFT_CAPACITY)
                {
                    emptySpots = LIFT_CAPACITY - lift[i];
                    if (people < emptySpots)
                    {
                        peopleToAdd = people;
                        lift[i] += peopleToAdd;
                    }
                    else
                    {
                        peopleToAdd = emptySpots;
                        lift[i] += peopleToAdd;
                    }
                    people -= peopleToAdd;
                }

                if (lift[i] == LIFT_CAPACITY)
                {
                    isWagonFull = true;
                }

            }

            if (people == 0 && !isWagonFull)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else if (people > 0 && isWagonFull)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else if (people == 0 || isWagonFull)
            {
                Console.WriteLine(string.Join(' ', lift));
            }
        }
    }
}
  
