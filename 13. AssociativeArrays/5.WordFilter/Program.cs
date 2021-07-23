﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
