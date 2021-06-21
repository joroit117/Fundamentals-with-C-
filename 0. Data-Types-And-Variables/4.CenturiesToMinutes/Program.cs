using System;
using System.Numerics;

namespace _4.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            double temp = 365.2422 * centuries * 100;
            long days = (long)temp;
            decimal minutes = days * 24 * 60;
            Console.WriteLine($"{centuries} centuries = {centuries * 100} years = {days} days = {days * 24} hours = {minutes} minutes");
        }
    }
}
