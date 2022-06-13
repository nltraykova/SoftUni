using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());

            double area = CalculateArea(width, height);

            Console.WriteLine(area);
        }

        static double CalculateArea(double width, double height)
        {
            double area = width * height;

            return area;
        }
    }
}
