using System;

namespace _4.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";

            for(int i = 0; i < input.Length; i++)
            {
                int temp = (int)input[i] + 3;
                output += (char)temp;
            }

            Console.WriteLine(output);
        }
    }
}
