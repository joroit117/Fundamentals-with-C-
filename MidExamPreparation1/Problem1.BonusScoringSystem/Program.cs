using System;

namespace Problem1.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfLectures = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());
            int maxBonus = Int32.MinValue;
            int maxAttendances = Int32.MinValue;
            for(int i = 0; i < numberOfStudents; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());
                double currentBonus = Math.Ceiling(studentAttendances / numberOfLectures * (5 + initialBonus));
                if(currentBonus >= maxBonus)
                {
                    maxBonus = (int)currentBonus;
                    maxAttendances = studentAttendances;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
