using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] sorted = (int[])numbers.OrderByDescending(n => n)
                .ToArray();

            Console.WriteLine(string.Join(" ", sorted.Take(3)));
                
        }
    }
}
