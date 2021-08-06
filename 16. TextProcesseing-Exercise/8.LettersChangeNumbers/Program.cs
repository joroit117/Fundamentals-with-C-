using System;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            double sum = 0.00;

            foreach(var input in inputs)
            {
                double number = 0.00;
                for(int i = 1; i < input.Length - 1; i++)
                {
                    number += Math.Pow(10, input.Length - 2 - i) * int.Parse(Convert.ToString(input[i]));
                }
                char firstLetter = input[0];
                if(firstLetter >=65 && firstLetter <= 90)
                {
                    int firstLetterPosition = firstLetter - 64;
                    number /= firstLetterPosition;
                }
                else if(firstLetter >= 97 && firstLetter <=122)
                {
                    int firstLetterPosition = firstLetter - 96;
                    number *= firstLetterPosition;
                }
                char lastLetter = input[input.Length - 1];
                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int lastLetterPosition = lastLetter - 64;
                    number -= lastLetterPosition;
                }
                else if (lastLetter >= 97 && lastLetter <= 122)
                {
                    int lastLetterPosition = lastLetter - 96;
                    number += lastLetterPosition;
                }
                sum += number;
                number = 0.00;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
