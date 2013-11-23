//2. Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Input binary number: ");
        uint number = uint.Parse(Console.ReadLine());
        List<uint> decimalNumber = new List<uint>();
        Console.Write("Decimal represenation of binary number {0} is: ", number);

        while (number > 0)
        {
            decimalNumber.Add(number % 2);
            number = (number-(number%2))/10;
        }

        for (int i = 0; i < decimalNumber.Count; i++)
        {
            number = number + decimalNumber[i]*(uint)Math.Pow(2,i);
        }
        Console.WriteLine(number);
    }
}
