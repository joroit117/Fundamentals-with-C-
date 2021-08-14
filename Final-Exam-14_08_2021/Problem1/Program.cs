using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            while(true)
            {
                string command = Console.ReadLine();

                if (command == "Complete") break;

                string[] commandSplitted = command.Split();

                switch (commandSplitted[0])
                {
                    case "Make":
                        if (commandSplitted[1] == "Upper")
                        {
                            foreach (var character in email)
                            {
                                email = email.Replace(character, Char.ToUpper(character));
                            }
                        }
                        else if(commandSplitted[1] == "Lower")
                        {
                            foreach (var character in email)
                            {
                                email = email.Replace(character, Char.ToLower(character));
                            }
                        }
                        Console.WriteLine(email);
                        break;
                    case "GetDomain":
                        int count = int.Parse(commandSplitted[1]);
                        for(int i = email.Length - count; i < email.Length; i++)
                        {
                            Console.Write(email[i]);
                        }
                        Console.WriteLine();
                        break;
                    case "GetUsername":
                        if(email.Contains("@"))
                        {
                            foreach(var character in email)
                            {
                                if (character == '@') break;
                                Console.Write(character);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        break;
                    case "Replace":
                        foreach(var character in email)
                        {
                            if(character == char.Parse(commandSplitted[1]))
                            {
                                email = email.Replace(character, '-');
                            }
                        }
                        Console.WriteLine(email);
                        break;
                    case "Encrypt":
                        string newEmail = "";
                        foreach(var character in email)
                        {
                            int asciiNum = character;
                            newEmail += asciiNum + " ";
                        }
                        Console.WriteLine(newEmail);
                        break;
                }

            }
        }
    }
}
