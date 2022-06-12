using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                sumLeft = 0;

                for (int j = i; j > 0; j--) 
                {
                    if (j > 0)
                    {
                        sumLeft += arr[j - 1]; 
                    }
                }

                sumRight = 0;

                for (int k = i; k < arr.Length; k++) 
                {
                    if (k < arr.Length - 1) 
                    {
                        sumRight += arr[k + 1]; 
                    }
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
               
            }

            Console.WriteLine("no");
        }
    }
}
