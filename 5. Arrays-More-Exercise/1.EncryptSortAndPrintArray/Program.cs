using System;

namespace _1.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arraySums = new int[n];
            int counter = 0;
            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                for(int j = 0; j < s.Length; j++)
                {
                    if ((int)s[j] >= 65 && (int)s[j] <= 90)
                    {
                        if(s[j] == 'A' || s[j] == 'E' || s[j] == 'I' || s[j] == 'O' || s[j] == 'U')
                        {
                            arraySums[counter] += ((int)s[j] * s.Length);
                        }
                        else
                        {
                            arraySums[counter] += ((int)s[j] / s.Length);
                        }
                    }
                    else if ((int)s[j] >= 97 && (int)s[j] <= 122)
                    {
                        if (s[j] == 'a' || s[j] == 'e' || s[j] == 'i' || s[j] == 'o' || s[j] == 'u')
                        {
                            arraySums[counter] += ((int)s[j] * s.Length);
                        }
                        else
                        {
                            arraySums[counter] += ((int)s[j] / s.Length);
                        }
                    }
                }
                counter++;
            }
            SortAndPrint(arraySums, n);
        }
        static void SortAndPrint(int[] arr, int n)
        {
            for(int i = 0; i < n-1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
