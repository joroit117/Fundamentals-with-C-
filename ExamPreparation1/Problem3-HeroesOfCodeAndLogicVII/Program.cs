using System;
using System.Collections.Generic;

namespace Problem3_HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for(int i = 0; i < numberOfHeroes; i++)
            {
                string[] hero = Console.ReadLine().Split();
                heroes.Add(hero[0], new List<int>());
                heroes[hero[0]].Add(int.Parse(hero[1]));
                heroes[hero[0]].Add(int.Parse(hero[2]));
            }

            while(true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                string[] commandSplitted = command.Split(" - ");

                switch (commandSplitted[0])
                {
                    case "CastSpell":
                        foreach(var hero in heroes)
                        {
                            if (hero.Key == commandSplitted[1])
                            {
                                if (hero.Value[0] >= int.Parse(commandSplitted[2]))
                                {
                                    hero.Value[0] -= int.Parse(commandSplitted[2]);
                                    Console.WriteLine($"{hero.Key} has successfully cast {commandSplitted[3]} and now has {hero.Value[0]} MP!");
                                }
                                else
                                {
                                    Console.WriteLine($"{hero.Key} does not have enough MP to cast {commandSplitted[3]}!");
                                }
                                break;
                            }
                        }
                        break;
                    case "TakeDamage":
                        foreach (var hero in heroes)
                        {
                            if (hero.Key == commandSplitted[1])
                            {
                                if (hero.Value[0] >= int.Parse(commandSplitted[2]))
                                {
                                    hero.Value[0] -= int.Parse(commandSplitted[2]);
                                    Console.WriteLine($"{hero.Key} has successfully cast {commandSplitted[3]} and now has {hero.Value[0]} MP!");
                                }
                                else
                                {
                                    Console.WriteLine($"{hero.Key} does not have enough MP to cast {commandSplitted[3]}!");
                                }
                                break;
                            }
                        }
                        break;
                }

            }
        }
    }
}
