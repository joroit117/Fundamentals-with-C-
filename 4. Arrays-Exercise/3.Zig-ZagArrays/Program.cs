using System;
using System.Linq;

namespace _3.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int arrSize = 0;
            for (int i = 1; i <= n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if(i % 2 == 0)
                {
                    arr1[arrSize] = nums[1];
                    arr2[arrSize] = nums[0];
                    arrSize++;
                }
                else
                {
                    arr1[arrSize] = nums[0];
                    arr2[arrSize] = nums[1];
                    arrSize++;
                }
                Array.Clear(nums, 0, nums.Length);
            }
            for(int i = 0; i < arrSize; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
