using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = 100 * double.Parse(Console.ReadLine());

            int count = 0;

            while (input > 0)
            {
                if (input >= 200)
                {
                    input -= 200;
                    count++;
                }
                else if (input >= 100)
                {
                    input -= 100;
                    count++;
                }
                else if (input >= 50)
                {
                    input -= 50;
                    count++;
                }
                else if (input >= 20)
                {
                    input -= 20;
                    count++;
                }
                else if (input >= 10)
                {
                    input -= 10;
                    count++;
                }
                else if (input >= 5)
                {
                    input -= 5;
                    count++;
                }
                else if (input >= 2)
                {
                    input -= 2;
                    count++;
                }
                else if (input >= 1)
                {
                    input -= 1;
                    count++;
                }
                else
                {
                    input = 0;
                }
            }

            Console.WriteLine(count);

        }
    }
}
