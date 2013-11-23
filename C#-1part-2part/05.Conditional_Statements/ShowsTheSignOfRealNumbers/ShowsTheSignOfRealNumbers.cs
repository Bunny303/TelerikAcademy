//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
//Use a sequence of if statements.


using System;

    class ShowsTheSignOfRealNumbers
    {
        static void Main()
        {
            //Input three real numbers
            Console.Write("Enter first real number:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second real number:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter third real number:");
            double c = double.Parse(Console.ReadLine());

            // If a,b and c are less than 0 or only one of them  is less than 0 then the product is -
            // If two of the numers are less than 0 or all of them are over 0 then the product is +
            
            if (((a < 0) && (b < 0) && (c < 0)) ^ ((a < 0) ^ (b < 0) ^ (c < 0)))
            {
                Console.WriteLine("The product of the three real numbers is: -");
            }
            else 
            {
                Console.WriteLine("The product of the three real numbers is: +");
            }
        }
    }
