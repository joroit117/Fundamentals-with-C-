using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while(n >= 1)
            {
                int digit = n % 10;
                if(digit % 2 == 0)
                {
                    sum += digit;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n >= 1)
            {
                int digit = n % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int n)
        {
            int evenSum = GetSumOfEvenDigits(n);
            int oddSum = GetSumOfOddDigits(n);
            return evenSum * oddSum;
        }
    }
}
