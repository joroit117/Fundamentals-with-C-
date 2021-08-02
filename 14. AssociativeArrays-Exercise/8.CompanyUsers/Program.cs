using System;
using System.Collections.Generic;
using System.Linq;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while(true)
            {
                string[] command = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();
                if(command[0] == "End")
                {
                    break;
                }
                else
                {
                    string companyName = command[0];
                    string employeeId = command[1];
                    if(!companies.ContainsKey(companyName))
                    {
                        companies.Add(companyName, new List<string>());
                    }
                    if(!companies[companyName].Contains(employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
            }
            foreach(var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach(var employeeID in company.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
