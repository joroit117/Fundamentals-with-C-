using System;

namespace _5.Digits_LettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = "";
            string leters = "";
            string symbols = "";

            for (int i = 0; i < input.Length; i++)
            {
                if(Char.IsDigit(input[i]))
                {
                    digits += input[i];
                }
                else if(Char.IsLetter(input[i]))
                {
                    leters += input[i];
                }
                else
                {
                    symbols += input[i];
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(leters);
            Console.WriteLine(symbols);
        }
    }
}
