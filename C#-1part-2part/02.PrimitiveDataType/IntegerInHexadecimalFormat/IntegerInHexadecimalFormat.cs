//Declare an integer variable and assign it with the value 254 in hexadecimal format. 
//Use Windows Calculator to find its hexadecimal representation.

using System;
    class IntegerInHexadecimalFormat
    {
        static void Main()
        {
            // Declare integer 254
            int i = 254;
            // Convert integer 254 as a hex in a string variable
            string hexi = i.ToString("X");
            Console.WriteLine(hexi);
        }
    }

