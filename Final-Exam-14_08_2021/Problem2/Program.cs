using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int registrationCounter = 0;
            int numberOfRegistrations = int.Parse(Console.ReadLine());
            for(int i = 0; i < numberOfRegistrations; i++)
            {
                string registration = Console.ReadLine();

                Regex registrationValidation = new Regex(@"U\$[A-Z][a-z]{2,}U\$P@\$[a-zA-Z]{5,}[0-9]{1,}P@\$");

                bool isRegistrationValid = registrationValidation.IsMatch(registration);

                if (isRegistrationValid)
                {
                    registrationCounter++;
                    Regex usernameRegex = new Regex(@"([A-Z][a-z]{2,})");
                    Regex passwordRegex = new Regex(@"([a-zA-Z]{5,}[0-9]{1,})");
                    Match um = usernameRegex.Match(registration);
                    Match pm = passwordRegex.Match(registration);
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {um.Groups[0].Value}, Password: {pm.Groups[0].Value}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {registrationCounter}");
        }
    }
}
