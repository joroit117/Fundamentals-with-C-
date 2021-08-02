using System;
using System.Collections.Generic;

namespace _2.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            string previousText = "";
            var resources = new Dictionary<string, int>();
            while (true)
            {
                string text = Console.ReadLine();
                if(text == "stop")
                {
                    break;
                }
                else
                {
                    if(index % 2 != 0)
                    {
                        if(!resources.ContainsKey(text))
                        {
                            resources.Add(text, 0);
                        }
                    }
                    else
                    {
                        resources[previousText] += int.Parse(text);
                    }
                }
                previousText = text;
                index++;
            }
            foreach(var item in resources)
            {
                Console.WriteLine(string.Join(Environment.NewLine, item.Key + " -> " + item.Value));
            }
        }
    }
}
