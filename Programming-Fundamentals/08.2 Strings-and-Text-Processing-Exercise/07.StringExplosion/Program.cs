using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strength = 0;


            StringBuilder newInput = new StringBuilder();
            
            
            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                
                if (currChar == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    newInput.Append(currChar);
                }
                else if (strength == 0)
                {
                    newInput.Append(input[i]);
                }
                else
                {
                    strength--;   
                }
            }

            Console.WriteLine(newInput);

        }
    }
}
