using System;

    class ReadIntegerNumber
    {
        static void Main()
        {
            Console.Write("a = ");
            string line = Console.ReadLine();
            int a = int.Parse(line);

            Console.Write("b = ");
            line = Console.ReadLine();
            int b = int.Parse(line);
            
            Console.Write("c = ");
            line = Console.ReadLine();
            int c = int.Parse(line);
            
            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);

        }
    }

