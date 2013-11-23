//Write a program that applies bonus scores to given scores in the range [1..9]. 
//The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; 
//if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
//If it is zero or if the value is not a digit, the program must report an error.
//Use a switch statement and at the end print the calculated new value in the console.

using System;

    class BonusScores
    {
        static void Main()
        {
            //Input digit
            Console.Write("Please enter a digit in the range [1..9]: ");
            ushort inputDigit = ushort.Parse(Console.ReadLine());

            //Check what case is input digit and print the calculated new value
            switch (inputDigit)
            { 
                case 1:
                case 2:
                case 3:
                    inputDigit *= 10;
                    Console.WriteLine("the calculated new value is {0}", inputDigit);
                    break;
                case 4:
                case 5:
                case 6:
                    inputDigit *= 100;
                    Console.WriteLine("the calculated new value is {0}", inputDigit);
                    break;
                case 7:
                case 8:
                case 9:
                    inputDigit *= 1000;
                    Console.WriteLine("The calculated new value is {0}", inputDigit);
                    break;
                default:
                    Console.WriteLine("Error"); break;
            }
        }
    }

