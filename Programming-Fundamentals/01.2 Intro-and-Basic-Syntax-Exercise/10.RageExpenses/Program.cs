using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine()); 
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalHeadsetPrice = 0.0;
            double totalMousePrice = 0.0;
            double totalKeyboardPrice = 0.0;
            double totalDisplayPrice = 0.0;

          
            int trashedKeyboardCount = 0;
            
            double totalExpenses = 0.0;
            

            for (int currLostGameCount = 1; currLostGameCount <= lostGamesCount; currLostGameCount++)
            {
                bool isHeadsetTrashed = false;
                bool isMouseTrashed = false;

                if (currLostGameCount % 2 == 0) 
                {
                    isHeadsetTrashed = true; 
                    totalHeadsetPrice += headsetPrice; 
                }

                if (currLostGameCount % 3 == 0) 
                {
                    isMouseTrashed = true;
                    totalMousePrice += mousePrice; 
                }

                if (isHeadsetTrashed && isMouseTrashed)
                {
                    trashedKeyboardCount++;
                    totalKeyboardPrice += keyboardPrice;
                }

                if (trashedKeyboardCount % 2 == 0 && trashedKeyboardCount !=0)
                {
                    totalDisplayPrice += displayPrice;
                    trashedKeyboardCount = 0;
                }
                
            }

            totalExpenses = totalHeadsetPrice + totalMousePrice + totalKeyboardPrice + totalDisplayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");

        }
    }
}
