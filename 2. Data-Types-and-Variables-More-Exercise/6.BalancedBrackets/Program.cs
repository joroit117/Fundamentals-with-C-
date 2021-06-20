using System;

namespace _6.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openedCounter = 0;
            bool isOpen = false;
            bool failed = false;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s[0] == '(' && s.Length == 1)
                {
                    openedCounter++;
                    if(openedCounter > 1)
                    {
                        failed = true;
                    }
                    isOpen = true;
                }
                else if (s[0] == ')' && s.Length == 1)
                {
                    if(isOpen == true)
                    {
                        isOpen = false;
                        openedCounter = 0;
                    }
                    else
                    {
                        failed = true;
                    }
                }
            }
            if(failed)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                Console.WriteLine("BALANCED");
            }
        }
    }
}
