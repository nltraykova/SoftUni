using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] initialField = new int[sizeOfField];
            
            int[] ladyBugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = 0;

            for (int i = 0; i < ladyBugsIndexes.Length; i++)
            {
               index = ladyBugsIndexes[i]; 
               initialField[index] = 1;  
            }

            string input = Console.ReadLine(); 

            while (input != "end") 
            {
                string[] command = input.Split().ToArray(); 

                int fromIndex = int.Parse(command[0]);
                string direction = command[1];
                int stepIndex = int.Parse(command[2]);
           
                while (initialField[fromIndex] != 0 && fromIndex < initialField.Length && fromIndex >= 0)
                {
                    initialField[fromIndex] = 0;

                    if (direction == "right")
                    {
                        for (int i = fromIndex; i <= initialField.Length - 1; i++)
                        {
                            if (i + stepIndex < initialField.Length)
                            {
                                if (initialField[i + stepIndex] != 1)
                                {
                                    initialField[i + stepIndex] = 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = fromIndex; i >= 0; i--)
                        {
                            if (i - stepIndex > 0)
                            {
                                if (initialField[i - stepIndex] != 1)
                                {
                                    initialField[i - stepIndex] = 1;
                                }
                            }
                        }
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', initialField));
        }
    }
}
