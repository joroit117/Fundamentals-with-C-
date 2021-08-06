using System;

namespace _6.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string sequence = "";
            bool isSequence = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    isSequence = true;
                    if(i + 1 == input.Length - 1)
                    {
                        sequence += input[i];
                    }
                }
                else 
                {
                    if(isSequence == true)
                    {
                        sequence += input[i];
                        isSequence = false;
                    }
                    else 
                    {
                        sequence += input[i];
                        if(i + 1 == input.Length - 1)
                        {
                            sequence += input[i + 1];
                        }
                    }
                }
            }
            Console.WriteLine(sequence);
        }
    }
}
