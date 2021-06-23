using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int[] top = new int[arr.Length];
            bool isTop = true;
            int topCounter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        isTop = false;
                        break;
                    }
                }
                if(isTop)
                {
                    top[topCounter] = arr[i];
                    topCounter++;
                }
                else
                {
                    isTop = true;
                }
            }
            for(int i = 0; i < topCounter; i++)
            {
                Console.Write(top[i] + " ");
            }
        }
    }
}
