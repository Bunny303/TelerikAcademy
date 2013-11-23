//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console.

using System;

    class PrintASCIITable
    {
        static void Main()
        {
            for (int charToConvert = 0; charToConvert <= 255; charToConvert++)
            {
                char symbol = (char)charToConvert;
                Console.WriteLine(symbol);
            }
        }
    }
