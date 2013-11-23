// 5. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Input hexadecimal number: ");
        string number = Console.ReadLine();
        string binaryNumber = "";
        string digit = "";
        Console.Write("Binary represenation of hexadecimal number {0} is: ", number);

        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case '0': digit = "0000"; break;
                case '1': digit = "0001"; break;
                case '2': digit = "0010"; break;
                case '3': digit = "0011"; break;
                case '4': digit = "0100"; break;
                case '5': digit = "0101"; break;
                case '6': digit = "0110"; break;
                case '7': digit = "0111"; break;
                case '8': digit = "1000"; break;
                case '9': digit = "1001"; break;
                case 'A':
                case 'a':
                    digit = "1010"; break;
                case 'B':
                case 'b':
                    digit = "1011"; break;
                case 'C':
                case 'c':
                    digit = "1100"; break;
                case 'D':
                case 'd':
                    digit = "1101"; break;
                case 'E':
                case 'e':
                    digit = "1110"; break;
                case 'F':
                case 'f':
                    digit = "1111"; break;
                default: break;
            }
            binaryNumber = binaryNumber + digit;
        }
        Console.WriteLine(binaryNumber);
    }
}
