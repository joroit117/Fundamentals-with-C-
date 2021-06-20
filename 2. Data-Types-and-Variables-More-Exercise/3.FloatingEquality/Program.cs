using System;

namespace _3.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            const double eps = 0.000001;
            bool isEqual = Math.Abs(a - b) < eps;
            Console.WriteLine(isEqual);
        }
    }
}
