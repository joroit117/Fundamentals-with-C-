using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> followers = new Dictionary<string, int>();

            while(true)
            {
                string command = Console.ReadLine();
                if (command == "Log out") break;
                string[] commandSplitted = command.Split(": ");
                switch(commandSplitted[0])
                {
                    case "New follower":
                        if(!followers.ContainsKey(commandSplitted[1]))
                        {
                            followers.Add(commandSplitted[1], 0);
                        }
                        break;
                    case "Like":
                        if(!followers.ContainsKey(commandSplitted[1]))
                        {
                            followers.Add(commandSplitted[1], 0);
                        }
                        followers[commandSplitted[1]] += (int.Parse(commandSplitted[2]));
                        break;
                    case "Comment":
                        if (!followers.ContainsKey(commandSplitted[1]))
                        {
                            followers.Add(commandSplitted[1], 0);
                        }
                        followers[commandSplitted[1]]++;
                        break;
                    case "Blocked":
                        if (!followers.ContainsKey(commandSplitted[1]))
                        {
                            Console.WriteLine($"{commandSplitted[1]} doesn't exist.");
                        }
                        else
                        {
                            followers.Remove(commandSplitted[1]);
                        }
                        break;
                }
            }
            Console.WriteLine($"{followers.Count} followers");
            foreach(var follower in followers.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{follower.Key}: {follower.Value}");
            }
        }
    }
}
