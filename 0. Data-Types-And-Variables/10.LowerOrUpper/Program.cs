using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            if((int)a > 64 && (int)a < 91)
            {
                Console.WriteLine("upper-case");
            }
            else if((int)a > 96 && (int)a < 123)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
