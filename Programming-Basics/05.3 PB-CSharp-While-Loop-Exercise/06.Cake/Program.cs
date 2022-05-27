using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); //широчина на тортата
            int lenght = int.Parse(Console.ReadLine()); //дължина на тортата
            
            int pieces = width * lenght; ///брой парчета от тортата на база широчината и дължината на тортата и това че едно парче е 1/1см
            
            string input = Console.ReadLine(); //броя парчета, които гостите вземат от тортата или командата "STOP"
            int countPieces = 0; //броя на взетите парчета
            

            while (input != "STOP")
            {
                countPieces += int.Parse(input);
                
                if (countPieces >= pieces)
                {
                    break;
                }
                
                input = Console.ReadLine();
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{pieces - countPieces} pieces are left.");
            }
            if (countPieces >= pieces)
            {
                Console.WriteLine($"No more cake left! You need {countPieces - pieces} pieces more.");
            }
        }
    }
}
