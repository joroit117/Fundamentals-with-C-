using System;

namespace _4.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[100];
            string s = Console.ReadLine();
            int j = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] != ' ')
                {
                    arr[j] += s[i];
                }
                else
                {
                    j++;
                }
            }
            for(int k = j; k >= 0; k--)
            {
                Console.Write(arr[k] + " ");
            }
        }
    }
}
