using System;
using System.Linq;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[nums.Length-1];
            if(nums.Length < 2)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        condensed[i] = nums[i] + nums[i + 1];
                    }
                    nums = condensed;
                }
                Console.WriteLine(condensed[0]);
            }
        }
    }
}
