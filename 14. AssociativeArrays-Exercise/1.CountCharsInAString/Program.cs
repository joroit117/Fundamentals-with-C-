using System;
using System.Collections.Generic;

namespace _1.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var chars = new Dictionary<char, int>();
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] != ' ')
                {
                    if(chars.ContainsKey(text[i]))
                    {
                        chars[text[i]]++;
                    }
                    else
                    {
                        chars.Add(text[i], 1);
                    }
                }
            }
            foreach(var item in chars)
            {
                Console.WriteLine(string.Join("\n", item.Key + " -> " + item.Value));
            }
        }
    }
}
