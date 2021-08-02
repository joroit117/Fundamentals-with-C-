using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var collection = new Dictionary<string, int>();
            var sorted = new Dictionary<string, int>();
            bool enough = false;
            string legendaryItem = "";
            while(!enough)
            {
                string[] text = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();
                for(int i = 0; i < text.Length; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        if (collection.ContainsKey(text[i]))
                        {
                            collection[text[i]] += int.Parse(text[i - 1]);
                        }
                        else
                        {
                            collection.Add(text[i], int.Parse(text[i - 1]));
                        }
                        if (collection[text[i]] >= 250)
                        {
                            switch (text[i])
                            {
                                case "shards":
                                    legendaryItem = "Shadowmourne";
                                    break;
                                case "fragments":
                                    legendaryItem = "Valanyr";
                                    break;
                                case "motes":
                                    legendaryItem = "Dragonwrath";
                                    break;
                            }
                            collection[text[i]] -= 250;
                            enough = true;
                            break;
                        }
                    }
                }
            }
            sorted.Add("shards", 0);
            sorted.Add("fragments", 0);
            sorted.Add("motes", 0);
            foreach (var item in collection)
            {
                if (item.Key == "shards" || item.Key == "fragments" || item.Key == "motes")
                {
                    sorted[item.Key] += item.Value;
                    collection.Remove(item.Key);
                }
            }
            sorted = sorted.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            collection = collection.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(legendaryItem + " obtained!");
            foreach(var item in sorted)
            {
                Console.WriteLine(string.Join("\n", item.Key + ": " + item.Value));
            }
            foreach(var item in collection)
            {
                Console.WriteLine(string.Join("\n", item.Key + ": " + item.Value));
            }
        }
    }
}
