using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int sum = 0;
            if (n % p != 0) sum++;
            Console.WriteLine(sum += n / p);
        }
    }
}
