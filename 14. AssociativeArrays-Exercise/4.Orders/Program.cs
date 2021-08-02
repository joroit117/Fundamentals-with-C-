using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> product = new Dictionary<string, List<double>>();
            while(true)
            { 
                string[] productInfo = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (productInfo[0] == "buy") break;
                else
                {
                    if(product.ContainsKey(productInfo[0]))
                    {
                       foreach(var item in product)
                        {
                            if(item.Key == productInfo[0])
                            {
                                if (item.Value[0] != double.Parse(productInfo[1]))
                                {
                                    item.Value[0] = double.Parse(productInfo[1]);
                                }
                                item.Value[1] += double.Parse(productInfo[2]);
                                item.Value[2] = item.Value[0] * item.Value[1];
                            }
                        }
                    }
                    else
                    {
                        product.Add(productInfo[0], new List<double>());
                        product[productInfo[0]].Add(double.Parse(productInfo[1]));
                        product[productInfo[0]].Add(double.Parse(productInfo[2]));
                        product[productInfo[0]].Add(double.Parse(productInfo[1]) * double.Parse(productInfo[2]));
                    }
                }
            }
            foreach(var item in product)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[2]:f2}");
            }
        }
    }
}
