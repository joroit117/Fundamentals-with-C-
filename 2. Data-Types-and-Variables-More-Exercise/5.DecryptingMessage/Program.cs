using System;

namespace _5.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decryptedMessage = "";
            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());
                c += (char) key;
                decryptedMessage += c.ToString();
            }
            Console.WriteLine(decryptedMessage);
        }
    }
}
