// 4. Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Input hexadecimal number: ");
        string number = Console.ReadLine();
        int decimalNumber = 0;
        int digit = 0;
        Console.Write("Decimal represenation of hexadecimal number {0} is: ", number);

        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case 'A':
                case 'a':
                    digit = 10; break;
                case 'B':
                case 'b':
                    digit = 11; break;
                case 'C':
                case 'c':
                    digit = 12; break;
                case 'D':
                case 'd':
                    digit = 13; break;
                case 'E':
                case 'e':
                    digit = 14; break;
                case 'F':
                case 'f':
                    digit = 15; break;
                default: digit = int.Parse(Convert.ToString(number[i])); break;
            }
            decimalNumber += digit * (int)Math.Pow(16,(number.Length-1-i));
        }
        Console.WriteLine(decimalNumber);
    }
}
