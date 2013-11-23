// 8. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Text;

class SignedInteger16bit
{
    static void Main()
    {
        Console.Write("Enter 16-bit signed integer number: ");
        int number = int.Parse(Console.ReadLine());

        StringBuilder binaryNumber= new StringBuilder();
        
        if (number >= 0)
        {
            while (number != 0)
            {
                binaryNumber.Append(number % 2);
                number = number / 2;
            }

            //Print 
            for (int i = binaryNumber.Length; i < 16; i++)
            {
                Console.Write("0");
            }
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(binaryNumber[i]);    
            }
            Console.WriteLine();
        }
        
        else
        {
            number = Math.Abs(number) - 1;

            while (number != 0)
            {
                binaryNumber.Append(number % 2);
                number = number / 2;
            }

            //Print 
            for (int i = binaryNumber.Length; i < 16; i++)
            {
                Console.Write("1");
            }
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (binaryNumber[i] == '0')
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
            }
            Console.WriteLine();
        }
    }
}
