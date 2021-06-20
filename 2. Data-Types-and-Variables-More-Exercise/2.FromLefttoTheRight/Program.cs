using System;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double n1 = 0, n2 = 0;
                string s = Console.ReadLine();
                string number1 = "", number2 = "";
                int j = 0, k = 0, p = 0, counterN1 = 0, counterN2 = 0, sumLeft = 0, sumRight = 0;
                bool firstHasMinus = false;
                bool secondHasMinus = false;
                while (s[j] != ' ')
                {
                    char c = s[j];
                    if (c == '-')
                    {
                        firstHasMinus = true;
                    }
                    number1 += c;
                    counterN1++;
                    j++;
                }
                j++;
                while (j < s.Length)
                {
                    char c = s[j];
                    if (c == '-')
                    {
                        secondHasMinus = true;
                    }
                    number2 += c;
                    counterN2++;
                    j++;
                }
                int temp1 = counterN1;
                int temp2 = counterN2;
                if (firstHasMinus)
                {
                    k = 1;
                    temp1--;
                }
                else
                {
                    k = 0;
                }
                if (secondHasMinus)
                {
                    temp2--;
                    p = 1;
                }
                else
                {
                    p = 0;
                }

                while (k < counterN1)
                {
                    n1 += Math.Pow(10, temp1 - 1) * int.Parse(number1[k].ToString());
                    sumLeft += int.Parse(number1[k].ToString());
                    k++;
                    temp1--;
                }
                if (firstHasMinus) n1 *= -1;

                while (p < counterN2)
                {
                    n2 += Math.Pow(10, temp2 - 1) * int.Parse(number2[p].ToString());
                    sumRight += int.Parse(number2[p].ToString());
                    p++;
                    temp2--;
                }
                if (secondHasMinus) n2 *= -1;
                if (n1 > n2)
                {
                    Console.WriteLine(sumLeft);
                }
                else
                {
                    Console.WriteLine(sumRight);
                }
            }
        }
    }
}
