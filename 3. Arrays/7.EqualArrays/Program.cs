﻿using System;
using System.Linq;

namespace _7.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] array2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumArray1 = 0;
            bool areIdentical = true;
            for(int i = 0; i < array1.Length; i++)
            {
                sumArray1 += array1[i];
                if(array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areIdentical = false;
                    break;
                }
            }
            if(areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumArray1}");
            }
        }
    }
}
