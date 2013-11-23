//Sort 3 real values in descending order using nested if statements.


using System;

    class SortRealNumbers
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

            // 1. a>b>c 
            // 2. a>c>b
            // 3. b>a>c
            // 4. b>c>a
            // 5. c>a>b
            // 6. c>b>a

            if ((a >= b) && (a>=c))
            {
                if (b >= c)
                {
                    Console.WriteLine("The descending order of the numbers is: {0}, {1}, {2}", a , b, c);
                }
                else
                {
                    Console.WriteLine("The descending order of the numbers is: {0}, {2}, {1}", a, b, c);
                }
            }

            else if ((b >= a) && (b >= c))
            {
                if (a >= c)
                {
                    Console.WriteLine("The descending order of the numbers is: {1}, {0}, {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("The descending order of the numbers is: {1}, {2}, {0}", a, b, c);
                }
            }

            else
            {
                if (a >= b)
                {
                    Console.WriteLine("The descending order of the numbers is: {2}, {0}, {1}", a, b, c);
                }
                else
                {
                    Console.WriteLine("The descending order of the numbers is: {2}, {1}, {0}", a, b, c);
                }
            }

            
        }
    }

