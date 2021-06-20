using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int counter = 0;
            double nMiddle = n / 2;
            while(n >= m)
            {
                n -= m;
                counter++;
                if(n == nMiddle)
                {
                    if(n>=y)
                    n = n / y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
