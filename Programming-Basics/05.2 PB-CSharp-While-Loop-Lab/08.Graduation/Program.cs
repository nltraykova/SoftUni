using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double annualGrade = 0.00;
            int grade = 1;
            double totalGrade = annualGrade; //0.00
            int count = 0;
            

            while (grade <= 12)
            {
                annualGrade = double.Parse(Console.ReadLine()); //5.00, 6.00, 5.00, 4.00, 6.00, 6.00, 5.00, 5.00, 6.00, 5.00, 4.00, 5.00
                
                if (annualGrade < 4.00) //false
                {
                    count++; //
                    
                    if (count < 2) //
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade"); // 
                        break;
                    }
                }
                totalGrade += annualGrade; //62.00
                grade++; //13
            }

            if (grade > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {totalGrade / 12:F2}");
            }
        }
    }
}
