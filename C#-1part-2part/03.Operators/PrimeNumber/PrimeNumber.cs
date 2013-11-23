using System;

    class PrimeNumber
    {
        static void Main()
        {
            Console.Write("Please enter number between 0 and 100: ");
            int n = int.Parse(Console.ReadLine());
            int p = 0;

            if ((n > 0) && (n < 100))
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        p = p + 1;

                    }
                    else
                    {
                        p = p + 0;
                    }
                }

                if (p == 0)
                {
                    Console.WriteLine("The number {0} is prime.", n);
                }
                else
                {
                    Console.WriteLine("The number {0} isn't prime.", n);
                }
            }

            else
            {
                Console.WriteLine("Your number is outside of the range");
            }

        }
    }

