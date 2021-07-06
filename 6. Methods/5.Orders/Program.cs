using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalPrice(product, quantity);
        }
        static void TotalPrice(string p, int q)
        {
            double price = 0;
            switch (p)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                   price = 2;
                    break;
            }
            Console.WriteLine($"{price * q:f2}");
        }
    }
}
