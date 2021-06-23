using System;
using System.Linq;

namespace _9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int[] best = new int[length];
            int bestLength = int.MinValue, bestIndex = int.MinValue, bestSum = int.MinValue, bestStart = -1;
            int index = 1;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] arr = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
                bool isOne = false;

                for(int i = 0; i < length; i++)
                {
                    if(arr[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if(arr[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if(arr[i] == 0 && isOne)
                    {
                        if(currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if(isOne)
                {
                    if(currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }

                if(currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestIndex = currentIndex;
                    bestSum = arr.Sum();
                    best = arr;
                    bestStart = index;
                }

                else if(currentLength == bestLength)
                {
                    if(currentIndex < bestIndex)
                    {
                        bestLength = currentLength;
                        bestIndex = currentIndex;
                        bestSum = arr.Sum();
                        best = arr;
                        bestStart = index;
                    }
                    else if(currentIndex == bestIndex)
                    {
                        if(arr.Sum() > bestSum)
                        {
                            bestLength = currentLength;
                            bestIndex = currentIndex;
                            bestSum = arr.Sum();
                            best = arr;
                            bestStart = index;
                        }
                    }
                }
                index++;
            }
            Console.WriteLine($"Best DNA sample {bestStart} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", best));
        }
    }
}
