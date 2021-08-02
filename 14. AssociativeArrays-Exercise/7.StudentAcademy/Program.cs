using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if(students.ContainsKey(studentName))
                {
                    students[studentName] = (students[studentName] + studentGrade) / 2.00;
                }
                else
                {
                    students.Add(studentName, studentGrade);
                }
            }
            foreach(var student in students.OrderByDescending(x => x.Value))
            {
                if(student.Value >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                }
            }
        }
    }
}
