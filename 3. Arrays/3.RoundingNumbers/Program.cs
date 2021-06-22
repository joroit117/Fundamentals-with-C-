using System;

namespace _3.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        { 
            double[] arr = new double[5];
            for (int i = 0; i < 5; i++)
            {
                double number = double.Parse(Console.ReadLine());
                arr[i] = number;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} => {1}", arr[i], Math.Round(arr[i], 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
