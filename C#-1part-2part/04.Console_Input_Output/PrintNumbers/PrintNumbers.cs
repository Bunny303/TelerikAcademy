using System;

    class PrintNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number n: ");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            for (i=1; i<=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

