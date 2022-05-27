using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine()); //3
            double washingMachine = double.Parse(Console.ReadLine()); //20.00
            double toyPrice = double.Parse(Console.ReadLine()); //2.00

            double money = 0;

            for (int i = 1; i <= age; i++) //цикълът ще се изпълнява три пъти
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1; //2.00 + (2*5 -1) = 2.00 + 9 = 11.00
                }
                else
                {
                    money += toyPrice; //2.00, 11.00 + 2.00 = 13.00
                }
            }

            if (money >= washingMachine) // 13 >= 20 -> false
            {
                Console.WriteLine($"Yes! {money - washingMachine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - money:F2}"); // 20 - 13 = 7
            }
        }
    }
}
