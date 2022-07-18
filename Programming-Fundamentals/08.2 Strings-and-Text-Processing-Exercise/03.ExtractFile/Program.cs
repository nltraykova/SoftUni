using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pathToFile = Console.ReadLine().Split('\\');

            string fileName = string.Empty;
            string extension = string.Empty;

            foreach (var item in pathToFile)
            {
                if (item.Contains('.'))
                {
                    string[] file = item.Split('.');

                    fileName = file[0];
                    extension = file[1];
                }
            }


            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
