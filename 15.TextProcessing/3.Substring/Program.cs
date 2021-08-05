using System;

namespace _3.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            line1 = line1.ToLower();
            line2 = line2.ToLower();

            while(true)
            {
                int index = line2.IndexOf(line1);
                if (index == -1) break;
                line2 = line2.Remove(index, line1.Length);
            }

            Console.WriteLine(line2);
            
            
        }
    }
}
