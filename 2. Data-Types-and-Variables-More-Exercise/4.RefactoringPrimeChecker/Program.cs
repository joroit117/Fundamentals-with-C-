﻿using System;

namespace _4.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
{
                bool isPrime = true;
                for (int j = 2; j < i; j++)
{
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime == true)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
                
            }
        }
    }
}
