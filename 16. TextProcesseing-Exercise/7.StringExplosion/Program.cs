using System;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strength = 0;
            string output = "";
            int i = 0;

            while (i < input.Length)
            {
                if(strength > 0)
                {
                    if(input[i] == '>')
                    {
                        strength += int.Parse(Convert.ToString(input[i + 1]));
                        output += input[i];
                        i++;
                    }
                    else
                    {
                        i++;
                        strength--;
                    }
                }
                else
                {
                    if (input[i] == '>')
                    {
                        strength += int.Parse(Convert.ToString(input[i + 1]));
                        output += input[i];
                        i++;
                    }
                    else
                    {
                        output += input[i];
                        i++;
                    }
                }
                
            }
            Console.WriteLine(output);
        }
    }
}
