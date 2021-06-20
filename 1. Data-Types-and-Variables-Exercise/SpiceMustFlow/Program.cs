using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int days = 0;
            while(n >= 100)
            {
                sum += n;
                n -= 10;
                sum -= 26;
                days++;
            }
            if (sum >= 26) sum -= 26;
            Console.WriteLine(days);
            Console.WriteLine(sum);
        }
    }
}
