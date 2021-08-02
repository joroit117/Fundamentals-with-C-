using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();
            while(true)
            {
                string[] command = Console.ReadLine()
                    .Split(" : ")
                    .ToArray();
                if(command[0] == "end")
                {
                    break;
                }
                else
                {
                    string courseName = command[0];
                    string studentName = command[1];
                    if(students.ContainsKey(courseName))
                    {
                        students[courseName].Add(studentName); 
                    }
                    else
                    {
                        students.Add(courseName, new List<string>());
                        students[courseName].Add(studentName);
                    }
                }
            }
            foreach(var student in students.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{student.Key}: {student.Value.Count}");
                student.Value.Sort();
                for(int i = 0; i < student.Value.Count; i++)
                {
                    Console.WriteLine($"-- {student.Value[i]}");
                }
        }
        }
    }
}
