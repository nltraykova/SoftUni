using System;

namespace _0.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading Arrays from the Console

            int n = int.Parse(Console.ReadLine()); //прочитаме число, което ще бъде дължината на масива

            int[] array = new int[n]; //създаваме масив с дължината на n

            for (int i = 0; i < array.Length; i++) //създаваме цикъл, който обхожда всички позиции на масива и всяка позиция присвоява стойност, която чете от конзолата
            {
                array[i] = int.Parse(Console.ReadLine());
            }

        }
    }
}
