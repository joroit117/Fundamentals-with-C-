using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;
            string first = input[0];
            string second = input[1];

            if (first.Length >= second.Length)
            {
                for(int i = 0; i < first.Length; i++)
                {
                    if(i < second.Length)
                    {
                        sum += (int)first[i] * (int)second[i];
                    }
                    else
                    {
                        sum += (int)first[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < second.Length; i++)
                {
                    if (i < first.Length)
                    {
                        sum += (int)first[i] * (int)second[i];
                    }
                    else
                    {
                        sum += (int)second[i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
