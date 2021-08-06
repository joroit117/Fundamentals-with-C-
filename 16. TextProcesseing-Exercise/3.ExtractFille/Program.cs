using System;

namespace _3.ExtractFille
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            int beginIndex = filePath.LastIndexOf("\\");
            int endIndex = filePath.IndexOf('.');

            string extension = filePath.Substring(endIndex + 1);

            filePath = filePath.Remove(endIndex);

            string fileName = filePath.Substring(beginIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
            
        }
    }
}
