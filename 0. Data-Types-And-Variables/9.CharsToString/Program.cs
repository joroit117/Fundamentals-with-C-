﻿using System;

namespace _9.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            string s = a.ToString() + b.ToString() + c.ToString();
            Console.WriteLine(s);
        }
    }
}
