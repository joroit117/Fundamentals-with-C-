using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                    {
                        char a = (char)(97 + i);
                        char b = (char)(97 + j);
                        char c = (char)(97 + k);
                        Console.WriteLine($"{a}{b}{c}");
                    }
        }
    }
}
