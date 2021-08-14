using System;
using System.Text.RegularExpressions;

namespace Problem2_FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex barcodeValidation = new Regex(@"@#+([A-Z][a-zA-Z0-9]+[A-Z]?\S{4})@#+");
            for(int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                bool barcodeIsValid = barcodeValidation.IsMatch(barcode);
                if(!barcodeIsValid)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    string group = "";
                    for(int j = 0; j < barcode.Length; j++)
                    {
                        if(Char.IsDigit(barcode[j]))
                        {
                            group += barcode[j];
                        }
                    }
                    if(group == "")
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {group}");
                    }
                }
            }
        }
    }
}
