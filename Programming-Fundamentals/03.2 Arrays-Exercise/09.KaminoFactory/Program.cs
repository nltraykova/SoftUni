using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            
            int[] DNA = new int[length];

            int dnaLength = -1;
            int dnaSum = 0;
            int dnaStartIndex = -1;
            int dnaSamples = 0;

            int sample = 0;

            while (input != "Clone them!")
            {
                int[] currDNA = input.Split('!').Select(int.Parse).ToArray();

                sample++;

                int currDNALength = 0;
                int currDNASum = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                
                bool isCurrDNABetter = false;

                int count = 0;
                for (int i = 0; i < currDNA.Length; i++) // 0 12 12 12 13
                {
                    if (currDNA[i] != 1) 
                    {
                       count = 0;
                       continue;
                    }

                    count++;
                    if (count > currDNALength)
                    {
                        currDNALength = count; //3
                        currEndIndex = i; //3
                    }
                }

                currStartIndex = (currEndIndex - currDNALength) + 1; 
                currDNASum = currDNA.Sum();

                if (currDNALength > dnaLength)
                {
                    isCurrDNABetter = true;
                }
                else if (currDNALength == dnaLength)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        isCurrDNABetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDNASum > dnaSum)
                        {
                            isCurrDNABetter = true;
                        }
                    }
                }
               

                if (isCurrDNABetter)
                {
                    DNA = currDNA;
                    dnaLength = currDNALength;
                    dnaSum = currDNASum;
                    dnaStartIndex = currStartIndex;
                    dnaSamples = sample;

                }

                input = Console.ReadLine();
            }

           
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(' ', DNA));
        }
    }
}
