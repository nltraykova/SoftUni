using System;
using System.Linq;

namespace _0.Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //First way
            //четем от конзолата поредица от числа разделени със спейс и ги записваме в стрингова променлива
            //string values = Console.ReadLine(); 

            //създаваме стрингов масив, където ще пазим стойностите от values, сплитнати по спейс
            //string[] items = values.Split(' ',StringSplitOptions.RemoveEmptyEntries); //.Split() - разделя по спейс по дифоут; 

            //създаваме интиджер масив с дължина, равна на стринговия масив
            //int[] array = new int[items.Length]; 

            // обхождаме интиджер масива, като за всяка позиция присвояваме стойност от същата позиция на стринговия масив.
            //for (int i = 0; i < array.Length; i++) /
            //{
            //    array[i] = int.Parse(items[i]); //парсваме стойността към инт
            //    Console.WriteLine(array[i]);
            //}

            //Second way
            //string values = Console.ReadLine();
            //string[] items = values.Split();
            //int[] array = items.Select(int.Parse).ToArray(); //пропускаме for цикъла като директно пълниме масива със стойностите от items, като преди това ги парснем към инт. Трябва да добавим System.Linq - за да ползаме ToArray;

            //Third way
            //четем от конзолата стригове, сплитваме ги по запетая + спейс, парсваме ги към инт и ги наливаме в масива
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        }
    }
}
