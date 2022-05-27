using System;

namespace _04.Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); //8
            int range = 1;

            while (range <= num) //true -> 1 < 8, 3 < 8, 7 < 8, fakse -> 15 < 8
            {
                Console.WriteLine(range); //1; 3; 7
                range = range * 2 + 1; //1*2+1 = 3, 3*2 + 1 = 7, 7*2 + 1 = 15
            }
        }
    }
}
