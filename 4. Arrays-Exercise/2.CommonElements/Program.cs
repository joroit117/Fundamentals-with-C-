using System;
using System.Linq;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                 .Split(' ');
            string[] arr2 = Console.ReadLine()
                 .Split(' ');
            string[] commonElements = new string[arr1.Length];
            int commonCounter = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if(arr2[i] == arr1[j])
                    {
                        commonElements[commonCounter] = arr2[i];
                        commonCounter++;
                    }
                }
            }
            for(int k = 0; k < commonCounter; k++)
            {
                Console.Write(commonElements[k] + " ");
            }
        }
    }
}
