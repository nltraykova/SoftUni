using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNum = Console.ReadLine(); //9999
            int multiplier = int.Parse(Console.ReadLine()); //9

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder result = new StringBuilder();
            StringBuilder revesedResult = new StringBuilder();

            int remainder = 0;
           

            for (int i = reallyBigNum.Length - 1; i >= 0; i--)
            {
                int currNum = int.Parse(reallyBigNum[i].ToString());
                
                int currResult =  currNum * multiplier + remainder; 

                int numToAdd = currResult % 10; 

                remainder = currResult / 10; 

                result.Append(numToAdd); 

                if (i == 0 && remainder != 0)
                {
                    result.Append(remainder);
                }
            }


            for (int i = result.Length - 1; i >= 0; i--)
            {
                revesedResult.Append(result[i]);
            }

            Console.WriteLine(revesedResult);
        }
    }
}
