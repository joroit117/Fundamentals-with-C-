using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestsnowballSnow = 0, bestsnowballTime = 0, bestsnowballQuality = 0;
            double bestsnowballValue = 0;
            for(int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowbalTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                double snowballValue = Math.Pow((snowballSnow / snowbalTime), snowballQuality);
                if(snowballValue > bestsnowballValue)
                {
                    bestsnowballValue = snowballValue;
                    bestsnowballTime = snowbalTime;
                    bestsnowballSnow = snowballSnow;
                    bestsnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {bestsnowballValue} ({bestsnowballQuality})");
        }
    }
}
