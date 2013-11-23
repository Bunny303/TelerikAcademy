//Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

    class DeclareCharacterVariable
    {
        static void Main()
        {
            int charToConvert = 72;
            char symbol = (char)charToConvert;
            Console.WriteLine(symbol);
        }
    }

