using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            bool hasChanges = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] elements = input.Split();
                switch (elements[0])
                {
                    case "Add":
                        hasChanges = true;
                        int numberToAdd = int.Parse(elements[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        hasChanges = true;
                        int numberToRemove = int.Parse(elements[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        hasChanges = true;
                        int indexToRemove = int.Parse(elements[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        hasChanges = true;
                        int numberToInsert = int.Parse(elements[1]);
                        int indexToInsert = int.Parse(elements[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Contains":
                        int numberToCheck = int.Parse(elements[1]);
                        bool contains = numbers.Contains(numberToCheck);
                        if (contains == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        string evens = "";
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                                evens += numbers[i] + " ";
                        }
                        Console.WriteLine(evens);
                        break;
                    case "PrintOdd":
                        string odds = "";
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                                odds += numbers[i] + " ";
                        }
                        Console.WriteLine(odds);
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string sign = elements[1];
                        int numberToCompare = int.Parse(elements[2]);
                        string result = "";
                        switch (sign)
                        {

                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < numberToCompare)
                                    {
                                        result += numbers[i] + " ";
                                    }
                                }
                                Console.WriteLine(result);
                                break;
                            case ">":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > numberToCompare)
                                    {
                                        result += numbers[i] + " ";
                                    }
                                }
                                Console.WriteLine(result);
                                break;
                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= numberToCompare)
                                    {
                                        result += numbers[i] + " ";
                                    }
                                }
                                Console.WriteLine(result);
                                break;
                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= numberToCompare)
                                    {
                                        result += numbers[i] + " ";
                                    }
                                }
                                Console.WriteLine(result);
                                break;
                        }
                        break;
                }
                if(hasChanges)
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
        }
    }
}
