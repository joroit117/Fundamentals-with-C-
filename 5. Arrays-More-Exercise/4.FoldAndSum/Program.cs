using System;
using System.Linq;

namespace _4.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = arr.Length / 4;
            int[] upper = new int[2 * k];
            int upperCounter = 0;
            int[] lower = new int[2 * k];
            int lowerCounter = 0;
            for (int i = k - 1; i >= 0; i--)
            {
                upper[upperCounter] += arr[i];
                upperCounter++;
            }
            for(int i = arr.Length - 1; i > arr.Length - k - 1; i--)
            {
                upper[upperCounter] += arr[i];
                upperCounter++;
            }
            for(int i = k; i < arr.Length - k; i++)
            {
                lower[lowerCounter] += arr[i];
                lowerCounter++;
            }
            for(int i = 0; i < upperCounter; i++)
            {
                upper[i] += lower[i];
            }
            for(int i = 0; i < upperCounter; i++)
            {
                Console.Write(upper[i] + " ");
            }
        }
    }
}
