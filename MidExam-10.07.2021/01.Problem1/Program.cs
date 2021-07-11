using System;

namespace _01.Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            float food = float.Parse(Console.ReadLine());
            float hay = float.Parse(Console.ReadLine());
            float cover = float.Parse(Console.ReadLine());
            float weight = float.Parse(Console.ReadLine());
            bool notEnough = false;

            for(int days = 1; days <= 30; days++)
            {
                food -= (float)0.3;
                if (days % 2 == 0)
                {
                    hay -= (float)0.05 * food;
                }
                if (days % 3 == 0)
                {
                    float temp = (float)1.0 / 3;
                    cover -= temp * weight;
                }
                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    notEnough = true;
                    break;
                }
            }
            if(notEnough)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
            }
        }
    }
}
