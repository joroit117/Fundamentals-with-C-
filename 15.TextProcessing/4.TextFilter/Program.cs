using System;

namespace _4.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannnedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            while(true)
            {
                int index = 0;
                foreach (var word in bannnedWords)
                {
                    index = text.IndexOf(word);
                    if(index == -1)
                    {
                        break;
                    }
                    string asterisk = new string('*', word.Length);
                    text = text.Replace(word, asterisk);
                }
                if(index == -1)
                {
                    break;
                }
            }
            Console.WriteLine(text);
        }
    }
}
