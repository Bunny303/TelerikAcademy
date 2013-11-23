//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

    class NullableValues
    {
        static void Main()
        {
            //assigns null values to an integer and to double variables.
            int? a = null;
            double? b = null;

            //Print nullable variables
            Console.WriteLine(a);
            Console.WriteLine(b);

            //try to add some values or the null literal to them and see the result.
            a = 5;
            Console.WriteLine(a);
            Console.WriteLine(b + 10);

        }
    }

