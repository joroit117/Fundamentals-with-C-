using System;

namespace _1.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach(var username in usernames)
            {
                bool isValid = true;
                if(username.Length >= 3 && username.Length <= 16)
                {
                    for(int i = 0; i < username.Length; i++)
                    {
                        if(Char.IsDigit(username[i]) || Char.IsLetter(username[i]) || username[i] == '-' || username[i] == '_')
                        {

                        }
                        else
                        {
                            isValid = false;
                        }
                    }
                }
                else 
                {
                    isValid = false;
                }
                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
