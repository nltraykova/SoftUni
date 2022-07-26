using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _06._ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z][\w*\.\-]*[A-Za-z]+\.[A-Za-z]+\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection emails = regex.Matches(input);

            emails.ToList().ForEach(Console.WriteLine);

        }
    }
}
