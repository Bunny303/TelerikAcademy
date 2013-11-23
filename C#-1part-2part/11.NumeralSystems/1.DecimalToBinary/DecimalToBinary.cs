// 1. Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Input decimal number: ");
        uint number = uint.Parse(Console.ReadLine());
        List<uint> binaryNumber= new List<uint>();
        Console.Write("Binary represenation of decimal number {0} is: ", number);

        while (number > 0)
        {
            binaryNumber.Add(number%2);
            number = number / 2;    
        }
                
        for (int i = binaryNumber.Count-1; i >= 0; i--)
        {
            Console.Write(binaryNumber[i]);
        }
        Console.WriteLine();

    }
}
