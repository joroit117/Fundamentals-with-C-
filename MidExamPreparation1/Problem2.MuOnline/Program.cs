using System;

namespace Problem2.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            bool isAlive = true;
            string[] commands = Console.ReadLine()
                .Split("|");
            for (int i = 0; i < commands.Length; i++)
            {
                string[] elements = commands[i].Split(" ");
                string command = elements[0];
                int number = int.Parse(elements[1]);
                switch (command)
                {
                    case "potion":
                        if (health + number <= 100)
                        {
                            health += number;
                            Console.WriteLine($"You healed for {number} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {100 - health} hp.");
                            health = 100;
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        break;
                    case "chest":
                        bitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                        break;
                    default:
                        health -= number;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {command}.");
                        }
                        else
                        {
                            isAlive = false;
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            i = commands.Length;
                        }
                        break;
                }
            }
            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
