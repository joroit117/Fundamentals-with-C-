using System;

namespace _1.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kilometers = 0;
            kilometers = meters / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
