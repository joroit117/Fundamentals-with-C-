using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int sum = 0;
            sum = (a + b) / c * d;
            Console.WriteLine(sum);
        }
    }
}
