using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            string splitBy = "";
            
            while(command != "Lumpawaroo")
            {
                string[] input;
                if(command.Contains("|"))
                {
                    input = command.Split("|");
                    splitBy = "|";
                }
                else
                {
                    input = command.Split("->");
                    splitBy = "->";
                }
                if(splitBy == "|")
                {
                    string side = input[0];
                    string forceUser = input[1];
          
                    if (!forceUsers.ContainsKey(side))
                    {
                        forceUsers.Add(side, new List<string>());
                    }
                    if(!forceUsers[side].Contains(forceUser))
                    {
                        forceUsers[side].Add(forceUser);
                    }
                }

                else if(splitBy == "->")
                {
                    string side = input[1];
                    string forceUser = input[0];

                    if (forceUsers[side].Contains(forceUser))
                    {
                        forceUsers[side].Remove(forceUser);
                        foreach (var f in forceUsers)
                        {
                            if(f.Key != side)
                            {
                                side = f.Key;
                                break;
                            }
                        }
                        forceUsers[side].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {side} side!");
                    }
                    
                    else
                    {
                        forceUsers[side].Add(forceUser);
                    }
                }
                command = Console.ReadLine();
            }

            foreach(var user in forceUsers.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine("Side: " + user.Key + ", Members: " + user.Value.Count);
                for(int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine("! " + user.Value[i]);
                }
            }
        }
    }
}
