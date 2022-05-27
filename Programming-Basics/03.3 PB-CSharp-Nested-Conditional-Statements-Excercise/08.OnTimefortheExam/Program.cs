using System;

namespace _08.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine()); //16  //16
            int minExam = int.Parse(Console.ReadLine()); //00  //00
            int hArrival = int.Parse(Console.ReadLine()); //15  //15
            int minArrival = int.Parse(Console.ReadLine()); //00  //30

            int timeExam = minExam + hExam * 60; //960 //960
            int timeArrival = minArrival + hArrival * 60; //900 //930
            
            int timeDiff = Math.Abs(timeExam - timeArrival); // 960 - 900 = 60 // 960 - 930 = 30
            int hDiff = timeDiff / 60; // 1 //0
            int mDiff = timeDiff % 60; // 0 //30

            
            if (timeExam >= timeArrival) //на време или много рано
            {
                if (timeDiff <= 30) //на време
                {
                    Console.WriteLine("On time");
                    if (minExam != minArrival)
                    {
                        Console.WriteLine($"{mDiff} minutes before the start");
                    }
                }
                else //много рано
                {
                    Console.WriteLine("Early");
                    if (hDiff < 1) //подранява до час
                    {
                        Console.WriteLine($"{mDiff} minutes before the start");
                    }
                    else //подранява над час
                    {
                        if (mDiff < 10)
                        {
                            Console.WriteLine($"{hDiff}:0{mDiff} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{hDiff}:{mDiff} hours before the start");
                        }
                    }
                }
            }
            else //закъснява
            {
                Console.WriteLine("Late");
                if (hDiff < 1) //закъснения до час
                {
                    Console.WriteLine($"{mDiff} minutes after the start");
                }
                else //закъснява над час
                    if (mDiff < 10) //минутите да под 10
                {
                    Console.WriteLine($"{hDiff}:0{mDiff} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hDiff}:{mDiff} hours after the start");
                }
            }
        }
    }
}
