using System;

namespace _7.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string multiplied = StringMultiplied(s, n);
            Console.WriteLine(multiplied);
        }
        static string StringMultiplied(string s, int n)
        {
            string multiplied = "";
            for(int i = 0; i < n; i++)
            {
                multiplied += s;
            }
            return multiplied;
        }
    }
}
