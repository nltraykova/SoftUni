using System;

namespace _01.PCStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double processorPriceDol = double.Parse(Console.ReadLine()); //цената в долари за процесора
            double videocardPriceDol = double.Parse(Console.ReadLine()); //цената в долари за видео карта
            double ramPriceDol = double.Parse(Console.ReadLine()); //цената в долари за една RAM памет
            int ramCount = int.Parse(Console.ReadLine());  //брой RAM памети
            double discount = double.Parse(Console.ReadLine()); //процент отстъпка


            double processorPriceBGN = processorPriceDol * 1.57;
            double videocardPriceBGN = videocardPriceDol * 1.57;
            double ramPriceBGN = ramPriceDol * 1.57;

            processorPriceBGN -= processorPriceBGN * discount;
            videocardPriceBGN -= videocardPriceBGN * discount;


            ramPriceBGN = ramPriceBGN * ramCount;

            double totalPrice = processorPriceBGN + videocardPriceBGN + ramPriceBGN;

            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");

        }
    }
}
