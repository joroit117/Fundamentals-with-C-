using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] ladybugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for(int i = 0; i < fieldSize; i++)
            {
                for(int j = 0; j < ladybugIndexes.Length; j++)
                {
                    if (i == ladybugIndexes[j])
                    {
                        field[i] = 1;
                    }
                }
            }
            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split();
                int index = int.Parse(parts[0]);
                string direction = parts[1];
                int lenght = int.Parse(parts[2]);
                if(field[index] != 0)
                {
                    if(direction == "right")
                    {
                        if(lenght > 0)
                        {
                            if(index + lenght > fieldSize - 1)
                            {
                                field[index] = 0;
                            }
                            else
                            {
                                if(field[index + lenght] == 0)
                                {
                                    field[index] = 0;
                                    field[index + lenght] = 1;
                                }
                                else
                                {
                                    while(field[index + lenght] != 0 && index + lenght < fieldSize - 1)
                                    {
                                        lenght++;
                                    }
                                    if(index + lenght < fieldSize - 1)
                                    {
                                        field[index + lenght] = 1;
                                        field[index] = 0;
                                    }
                                    else
                                    {
                                        field[index] = 0;
                                    }
                                }
                            }
                        }
                        else
                        {
                            lenght = Math.Abs(lenght);
                            if (index - lenght < 0)
                            {
                                field[index] = 0;
                            }
                            else
                            {
                                if (field[index - lenght] == 0)
                                {
                                    field[index] = 0;
                                    field[index - lenght] = 1;
                                }
                                else
                                {
                                    while (field[index - lenght] != 0 && index - lenght >= 0)
                                    {
                                        lenght--;
                                    }
                                    if (index - lenght >= 0)
                                    {
                                        field[index - lenght] = 1;
                                        field[index] = 0;
                                    }
                                    else
                                    {
                                        field[index] = 0;
                                    }
                                }
                            }
                        }
                    }
                    if(direction == "left")
                    {
                        if(lenght > 0)
                        {
                            if(index - lenght < 0)
                            {
                                field[index] = 0;
                            }
                            else
                            {
                                if (field[index - lenght] == 0)
                                {
                                    field[index] = 0;
                                    field[index - lenght] = 1;
                                }
                                else
                                {
                                    while (field[index - lenght] != 0 && index - lenght >= 0)
                                    {
                                        lenght--;
                                    }
                                    if (index - lenght >= 0)
                                    {
                                        field[index - lenght] = 1;
                                        field[index] = 0;
                                    }
                                    else
                                    {
                                        field[index] = 0;
                                    }
                                }
                            }
                        }
                        else
                        {
                            lenght = Math.Abs(lenght);
                            if (index + lenght > fieldSize - 1)
                            {
                                field[index] = 0;
                            }
                            else
                            {
                                if (field[index + lenght] == 0)
                                {
                                    field[index] = 0;
                                    field[index + lenght] = 1;
                                }
                                else
                                {
                                    while (field[index + lenght] != 0 && index + lenght < fieldSize - 1)
                                    {
                                        lenght++;
                                    }
                                    if (index + lenght < fieldSize - 1)
                                    {
                                        field[index + lenght] = 1;
                                        field[index] = 0;
                                    }
                                    else
                                    {
                                        field[index] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            for(int i = 0; i < fieldSize; i++)
            {
                Console.Write(field[i] + " ");
            }
        }
    }
}
