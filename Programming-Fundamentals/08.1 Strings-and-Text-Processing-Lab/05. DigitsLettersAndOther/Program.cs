using System;
using System.Text;

namespace _05._DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();


            foreach (var ch in someString)
            {
                if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else if(char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    others.Append(ch);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
