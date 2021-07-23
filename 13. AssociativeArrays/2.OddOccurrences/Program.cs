using System;
using System.Collections.Generic;

namespace _2.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach(string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if(counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;
                }
                else
                {
                    counts.Add(wordInLowerCase, 1);
                }
            }

            foreach(var item in counts)
            {
                if(item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
