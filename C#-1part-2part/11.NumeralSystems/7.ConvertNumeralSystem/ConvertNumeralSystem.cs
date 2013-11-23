// 7. Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Text;

class ConvertNumeralSystem
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = (Console.ReadLine()).ToUpper();
        Console.Write("Please enter s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter d: ");
        int d = int.Parse(Console.ReadLine());
 
        if (s < 2 || d < 2 || s > 16 || d > 16)
        {
            Console.WriteLine("Invalid numeral systems");
        }
        else 
        {
            ConvertFromDecimal(ConvertToDecimal(number, s), d);
        }
    }

    static int ConvertToDecimal(string number, int s)
    {
        int decimalNumber = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > '9')
            {
                decimalNumber = decimalNumber + (number[i] - '7') * (int)Math.Pow(s, (number.Length - 1 - i));
            }
            else
            {
                decimalNumber = decimalNumber + (number[i] - '0') * (int)Math.Pow(s, (number.Length - 1 - i));
            }
        }

        return decimalNumber;
    }

    static void ConvertFromDecimal(int number, int d)
    {
        StringBuilder convertedNumber = new StringBuilder();
        int digit = 0;

        if (d > 10)
        {
            while (number > 0)
            {
                digit = number % d;
                number = number / d;
                switch (digit)
                {
                    case 10: convertedNumber.Append("A"); break;
                    case 11: convertedNumber.Append("B"); break;
                    case 12: convertedNumber.Append("C"); break;
                    case 13: convertedNumber.Append("D"); break;
                    case 14: convertedNumber.Append("E"); break;
                    case 15: convertedNumber.Append("F"); break;
                    default: convertedNumber.Append(digit); break;
                }
            }
        }
        else
        {
            while (number > 0)
            {
                digit = number % d;
                number = number / d;
                convertedNumber.Append(digit);
            }
        }
        
        for (int i = convertedNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(convertedNumber[i]);
        }
        Console.WriteLine();
    }
}
