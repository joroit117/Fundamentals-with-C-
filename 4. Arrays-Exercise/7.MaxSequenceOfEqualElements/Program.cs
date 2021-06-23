using System;
using System.Linq;

namespace _7.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int maxSequence = 0;
            int[] maxArr = new int[arr.Length];
            int tempMaxSequence = 0;
            int[] tempMaxArr = new int[arr.Length];
            int i = 0;
            bool noEnd = false;
            while (i < arr.Length - 1)
            {
                if(arr[i] == arr[i+1])
                {
                    tempMaxArr[tempMaxSequence] = arr[i];
                    tempMaxSequence++;
                    i++;
                    if(i >= arr.Length - 1)
                    {
                        noEnd = true;
                    }
                }
                else
                { 
                    tempMaxArr[tempMaxSequence] = arr[i];
                    tempMaxSequence++;
                    if(tempMaxSequence > maxSequence)
                    {
                        for(int j = 0; j < tempMaxSequence; j++)
                        {
                            maxArr[j] = tempMaxArr[j];
                        }
                        maxSequence = tempMaxSequence;
                        Array.Clear(tempMaxArr, 0, tempMaxSequence);
                        tempMaxSequence = 0;
                    }
                    else
                    {
                        Array.Clear(tempMaxArr, 0, tempMaxSequence);
                        tempMaxSequence = 0;
                    }
                    i++;
                }
                if(noEnd)
                {
                    tempMaxArr[tempMaxSequence] = arr[i];
                    tempMaxSequence++;
                    if (tempMaxSequence > maxSequence)
                    {
                        for (int j = 0; j < tempMaxSequence; j++)
                        {
                            maxArr[j] = tempMaxArr[j];
                        }
                        maxSequence = tempMaxSequence;
                        Array.Clear(tempMaxArr, 0, tempMaxSequence);
                        tempMaxSequence = 0;
                    }
                }
            }
            for (int k = 0; k < maxSequence; k++)
            {
                Console.Write(maxArr[k] + " ");
            }
        }
    }
}
