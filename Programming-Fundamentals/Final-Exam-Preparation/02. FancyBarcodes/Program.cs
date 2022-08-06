using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern = @"@#+[A-Z][A-Za-z\d]{4,}[A-Z]@#+";

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string barcode = Console.ReadLine();

                if (Regex.IsMatch(barcode, barcodePattern))
                {
                    char[] digits = barcode.Where(char.IsDigit).ToArray();

                    string productGroup = string.Empty;

                    if (digits.Length > 0)
                    {
                        foreach (var digit in digits)
                        {
                            productGroup += digit;
                        }
                    }
                    else
                    {
                        productGroup = "00";
                    }
                   
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
