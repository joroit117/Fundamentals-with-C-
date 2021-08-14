using System;

namespace Problem1_PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            while(true)
            {
                string command = Console.ReadLine();
                if (command == "Done") break;
                string[] commandSplitted = command.Split();
                switch (commandSplitted[0])
                {
                    case "TakeOdd":
                        string newPassword = "";
                        for (int i = 1; i < text.Length; i+=2)
                        {
                            newPassword += text[i];
                        }
                        text = newPassword;
                        Console.WriteLine(text);
                        break;
                    case "Cut":
                        int size = text.Length;
                        string temp = text;
                        text = temp.Substring(0, int.Parse(commandSplitted[1]));
                        text += temp.Substring(int.Parse(commandSplitted[1]) + int.Parse(commandSplitted[2]), size - int.Parse(commandSplitted[1]) - int.Parse(commandSplitted[2]));
                        Console.WriteLine(text);
                        break;
                    case "Substitute":
                        if (text.Contains(commandSplitted[1]))
                        {
                            text = text.Replace(commandSplitted[1], commandSplitted[2]);
                            Console.WriteLine(text);
                        }
                        else 
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }

            }
            Console.WriteLine($"Your password is: {text}");
        }
    }
}
