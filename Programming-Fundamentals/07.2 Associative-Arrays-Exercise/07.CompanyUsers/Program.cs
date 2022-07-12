using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] tokens = cmd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees.Add(companyName, new List<string>());
                }

                if (!companyEmployees[companyName].Any(id => id == employeeId))
                {
                    companyEmployees[companyName].Add(employeeId);
                }
                
                cmd = Console.ReadLine();
            }


            foreach (var employee in companyEmployees)
            {
                Console.WriteLine(employee.Key);

                foreach (var id in employee.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
