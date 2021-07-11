using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();
            while(true)
            {
                List<string> commands = Console.ReadLine()
                .Split(" ")
                .ToList();
                if(commands[0] == "end")
                {
                    break;
                }
                switch (commands[0])
                {
                    case "Chat":
                        chat.Add(commands[1]);
                        break;
                    case "Delete":
                        chat.Remove(commands[1]);
                        break;
                    case "Edit":
                        bool isIn = chat.Contains(commands[1]);
                        int index = chat.IndexOf(commands[1]);
                        if (isIn)
                        {
                            chat.Remove(commands[1]);
                            chat.Insert(index, commands[2]);
                        }
                        break;
                    case "Pin":
                        bool exist = chat.Contains(commands[1]);
                        if (exist)
                        {
                            chat.Remove(commands[1]);
                            chat.Add(commands[1]);
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < commands.Count; i++)
                        {
                            chat.Add(commands[i]);
                        }
                        break;
                }
            }
            for(int i = 0; i < chat.Count(); i++)
            {
                Console.WriteLine(chat[i]);
            }
        }
    }
}
