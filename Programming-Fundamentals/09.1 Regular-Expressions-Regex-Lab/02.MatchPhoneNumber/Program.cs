﻿using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string telephoneNumbers = Console.ReadLine();
            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(telephoneNumbers);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
