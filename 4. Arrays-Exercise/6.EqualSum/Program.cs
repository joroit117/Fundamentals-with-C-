using System;
using System.Linq;

namespace _6.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int leftSum = 0, rightSum = 0;
            bool exist = false;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for(int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }
                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    exist = true;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if(!exist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
