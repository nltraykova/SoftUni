using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int theLongestlenghtOfSequence = 0;
            int currentLengthOfSequence = 0;
            int currentNumber = 0;
           

            for (int i = numbers.Length - 1; i > 0; i--) 
            {

                if (numbers[i] == numbers[i - 1]) 
                {
                    currentLengthOfSequence++;
                    
                    if (currentLengthOfSequence >= theLongestlenghtOfSequence)
                    {
                        theLongestlenghtOfSequence = currentLengthOfSequence;
                        currentNumber = numbers[i];
                    }
                }
                else
                {
                    currentLengthOfSequence = 0;
                }
            }

                int[] longestArray = new int[theLongestlenghtOfSequence + 1];

                for (int i = 0; i < longestArray.Length; i++)
                {
                    longestArray[i] = currentNumber;
                }

                Console.WriteLine(string.Join(' ', longestArray));
        }
    }
}
