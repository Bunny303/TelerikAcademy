using System;

    class CountNumbersBetweenNumbers
    {
        static void Main()
        {
            Console.Write("Enter first positive number: ");
            string FirstNumber = Console.ReadLine();
            uint a = uint.Parse(FirstNumber);

            Console.Write("Enter second positive number: ");
            string SecondNumber = Console.ReadLine();
            uint b = uint.Parse(SecondNumber);

            // To write check for which numer is bigger a or b
            int counter = 0;
            if (a <= b)
            {
                for (uint i = a; i <= b; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter = counter + 1;
                    }
                    else
                    {
                        counter = counter + 0;
                    }
                }
            }
            else
            {
                for (uint i = b; i <= a; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter = counter + 1;
                    }
                    else
                    {
                        counter = counter + 0;
                    }
                }
            }
            Console.WriteLine("p({0},{1})={2}", a, b, counter);

        }
    }
