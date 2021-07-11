using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            while(true)
            {
                List<string> command = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                if(command[0] == "Finish")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "Replace":
                        bool isIn = numbers.Contains(int.Parse(command[1]));
                        int index = numbers.IndexOf(int.Parse(command[1]));
                        if (isIn)
                        {
                            numbers.Remove(int.Parse(command[1]));
                            numbers.Insert(index, int.Parse(command[2]));
                        }
                        break;
                    case "Collapse":
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if(numbers[i] < int.Parse(command[1]))
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
