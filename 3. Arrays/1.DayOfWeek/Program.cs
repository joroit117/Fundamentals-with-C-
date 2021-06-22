using System;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            const int days = 7;
            string[] arr = new string[days];
            arr[0] = "Monday";
            arr[1] = "Tuesday";
            arr[2] = "Wednesday";
            arr[3] = "Thursday";
            arr[4] = "Friday";
            arr[5] = "Saturday";
            arr[6] = "Sunday";
            int n = int.Parse(Console.ReadLine());
            if(n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(arr[n-1]);
            }
        }
    }
}
