//1. Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

//2. Declare two string variables and assign them with following value: "The "use" of quotations causes difficulties."
//Do the above in two different ways: with and without using quoted strings.


using System;

    class DeclareStringVariables
    {
        static void Main()
        {
            //Declare two string variables and assign them with “Hello” and “World”. 
            string firstword = "Hello";
            string secondword = "World";

            //Declare an object variable and assign it with the concatenation of the first two variables 
            //(mind adding an interval).
            object firstAndSecond = "Hello World";

            //Declare a third string variable and initialize it with the value of the object variable 
            //(you should perform type casting).
            string thirdword = firstword + " " + secondword;

            //Declare two string variables and assign them with following value: "The "use" of quotations causes difficulties."
            string firstsentence = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(firstsentence);
            string secondsentence = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(secondsentence);
         }
    }

