// 3. Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Input decimal number: ");
        uint number = uint.Parse(Console.ReadLine());
        List<string> hexadecimalNumber = new List<string>();
        Console.Write("Hexadecimal represenation of decimal number {0} is: ", number);

        while (number > 0)
        {
            switch (number % 16)
            {
                case 10:
                    hexadecimalNumber.Add("A");
                    break;
                case 11:
                    hexadecimalNumber.Add("B");
                    break;
                case 12:
                    hexadecimalNumber.Add("C");
                    break;
                case 13:
                    hexadecimalNumber.Add("D");
                    break;
                case 14:
                    hexadecimalNumber.Add("E");
                    break;
                case 15:
                    hexadecimalNumber.Add("F");
                    break;
                default:
                    hexadecimalNumber.Add(number % 16+"");
                    break;
            }
            number = number / 16;
        }
        for (int i = hexadecimalNumber.Count - 1; i >= 0; i--)
        {
            Console.Write(hexadecimalNumber[i]);
        }
        Console.WriteLine();
        
    }
}
