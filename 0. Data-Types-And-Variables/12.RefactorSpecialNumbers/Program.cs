using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isPrime = false;
            for (int i = 1; i <= n; i++)
{
                int tempVar = i;
                while (tempVar > 0)
{
                    sum += tempVar % 10;
                    tempVar = tempVar / 10;
                }
                isPrime = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isPrime);
                sum = 0;
            }
        }
    }
}
