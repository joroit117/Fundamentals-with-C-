using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> user = new Dictionary<string, string>();
            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();
                if(command[0] == "register")
                {
                    if (user.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                    else
                    {
                        user.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if(command[0] == "unregister")
                {
                    if(user.ContainsKey(command[1]))
                    {
                        user.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }

            foreach(var u in user)
            {
                Console.WriteLine($"{u.Key} => {u.Value}");
            }
        }
    }
}
