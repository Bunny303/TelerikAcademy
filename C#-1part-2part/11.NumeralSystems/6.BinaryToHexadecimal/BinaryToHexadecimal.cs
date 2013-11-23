// 6. Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Input binary number: ");
        string number = Console.ReadLine();
        string hexadecimalNumber = "";
        string digit = "";
        string binaryDigit = "";
        Console.Write("Hecadecimal represenation of binary number {0} is: ", number);

        for (int i = 0; i < number.Length/4; i++)
        {
            for (int j = (i*4+1); j <= ((i + 1) * 4); j++)
            {
                binaryDigit = binaryDigit + number[j-1];
            }
            switch (binaryDigit)
            {
                case "0000": digit = "0"; break;
                case "0001": digit = "1"; break;
                case "0010": digit = "2"; break;
                case "0011": digit = "3"; break;
                case "0100": digit = "4"; break;
                case "0101": digit = "5"; break;
                case "0110": digit = "6"; break;
                case "0111": digit = "7"; break;
                case "1000": digit = "8"; break;
                case "1001": digit = "9"; break;
                case "1010": digit = "A"; break;
                case "1011": digit = "B"; break;
                case "1100": digit = "C"; break;
                case "1101": digit = "D"; break;
                case "1110": digit = "E"; break;
                case "1111": digit = "F"; break;
                default: break;
            }
            hexadecimalNumber = hexadecimalNumber + digit;
            binaryDigit = "";
        }
        Console.WriteLine(hexadecimalNumber);
    }
}
