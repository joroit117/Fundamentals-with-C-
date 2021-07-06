using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MergingListss
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> numbers2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            int resLenght = 0;
            bool isFirstSmaller = false;
            if(numbers1.Count < numbers2.Count)
            {
                resLenght = numbers1.Count;
                isFirstSmaller = true;
            }
            else
            {
                resLenght = numbers2.Count;
                isFirstSmaller = false;
            }
            for(int i = 0; i < resLenght; i++)
            {
                result.Add(numbers1[i]);
                result.Add(numbers2[i]);
            }
            if(isFirstSmaller)
            {
                for(int i = resLenght; i < numbers2.Count; i++)
                {
                    result.Add(numbers2[i]);
                }
            }
            else
            {
                for (int i = resLenght; i < numbers1.Count; i++)
                {
                    result.Add(numbers1[i]);
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
