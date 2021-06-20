using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tank = 0;

            for(int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                tank += liters;
                if (tank > 255) { Console.WriteLine("Insufficient capacity!"); tank -= liters; }
            }
            Console.WriteLine(tank);
        }
    }
}
