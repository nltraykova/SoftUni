﻿using System;

namespace _04.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            switch (gender)
            {
                case 'm':
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }
                    break;
                case 'f':
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    break;
            }
        }
    }
}
