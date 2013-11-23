//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

    class ReturnMinMaxNumber
    {
        static void Main()
        {
            //Define number of compared numbers
            Console.Write("Please enter how many numbers will comparing? : ");
            uint N = uint.Parse(Console.ReadLine());

            //Input numbers and compare them
            int minNumber=0;
            int maxNumber=0;

            for (int i=1; i <= N; i++)
            {
                Console.Write("Please enter a number: ");
                int inputNumber = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    minNumber = inputNumber;
                    maxNumber = inputNumber;
                }
                else if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }
                else 
                {
                    maxNumber = inputNumber;
                }
            }

            //Print the results
            Console.WriteLine("The minimal number is {0}", minNumber);
            Console.WriteLine("The maximal number is {0}", maxNumber);

        }
    }

