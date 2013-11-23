//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
using System;

    class TriangleOfCopyrightSymbols
    {
        static void Main()
        {
            int charCode = 169;
            char symbol = (char)charCode;
            string triangleFirstRow = "  " + symbol;
            Console.WriteLine(triangleFirstRow);
            string triangleSecondRow = " " + symbol + " " + symbol;
            Console.WriteLine(triangleSecondRow);
            string triangleThirdRow = symbol + " " + symbol + " " + symbol;
            Console.WriteLine(triangleThirdRow);

        }
    }

