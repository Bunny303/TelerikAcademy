//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.

using System;

    class UsersChoiceInput
    {
        static void Main()
        {
            // Read user's choice input
            Console.Write("Please write something: ");
            string inputValue = Console.ReadLine();

            //Declare variables
            int inputValueInteger = 0;
            double inputValueDouble = 0.0d;
            bool checkInteger = int.TryParse(inputValue, out inputValueInteger);
            bool checkDouble = double.TryParse(inputValue, out inputValueDouble);

            //Check if the variable is integer
            switch (checkInteger)
            {
                //If it's not integer, check if the variable is double
                case false: 
                    switch (checkDouble)
                    {
                        // If it's not double, it's string and print the result
                        case false: Console.WriteLine(inputValue + "*"); break;
                        // If it is double and print the result
                        case true: Console.WriteLine(inputValueDouble + 1); break;
                        default: Console.WriteLine("Wrong inputValueInteger value"); break;
                    }
                break;
                // if it's integer and print the result
                case true: Console.WriteLine(inputValueInteger + 1); break;
                default: Console.WriteLine("Wrong inputValueInteger value"); break;
            }


        }
    }

