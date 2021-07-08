using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ")
                .ToList();
            while(true)
            {
                string command = Console.ReadLine();
                if(command == "Craft!")
                {
                    break;
                }
                else
                {
                    List<string> elements = command
                        .Split(" - ")
                        .ToList();
                    switch (elements[0])
                    {
                        case "Collect":
                            inventory.Add(elements[1]);
                            break;
                        case "Drop":
                            inventory.Remove(elements[1]);
                            break;
                        case "Combine Items":
                            List<string> combine = elements[1]
                                .Split(":")
                                .ToList();
                            bool exist = inventory.Contains(combine[0]);
                            if(exist)
                            {
                                int index = inventory.IndexOf(combine[0]);
                                inventory.Insert(index + 1, combine[1]);
                            }
                            break;
                        case "Renew":
                            bool isIn = inventory.Contains(elements[1]);
                            if(isIn)
                            {
                                inventory.Remove(elements[1]);
                                inventory.Add(elements[1]);
                            }
                            break;
                    }

                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
