//Write an if statement that examines two integer variables and exchanges their values 
//if the first one is greater than the second one.

using System;

    class ExchangesValuesOfTwoIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter a:"); //input first integer "a"
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:"); //input second integer "b"
            int b = int.Parse(Console.ReadLine());

            if (a > b) 
            {
                Console.WriteLine("a={0}, b={1}", b, a); //If a>b exchanges their value
            }
            else
            {
                Console.WriteLine("a={0}, b={1}", a, b); //If a<b their values stay the same
            }
        }
    }

