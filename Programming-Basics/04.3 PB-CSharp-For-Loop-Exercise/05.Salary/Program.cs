using System;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //3
            int salary = int.Parse(Console.ReadLine()); //900

            int penalty = 0;
           
            for (int i = 1; i <= n; i++) //цикълът ще се изпълти три пъти
            {
                string site = Console.ReadLine(); //Facebook, Reddit, Facebook

                if (site == "Facebook")
                {
                    penalty += 150; //1. penalty = 150, 3. penalty = 200 + 150 = 350
                }
                else if (site == "Instagram")
                {
                    penalty += 100;
                }
                else if (site == "Reddit")
                {
                    penalty += 50; //2. penalty = 150 + 50 = 200
                }
                if (salary - penalty <= 0) //900 - 150 <= 0 -> false; 900 - 200 = 700 -> false; 900 - 350 <=0 -> false
                {
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }
            }
            if (salary - penalty > 0)
            {
                Console.WriteLine(salary - penalty); //900 - 350 = 550
            }
           
        }
    }
}
