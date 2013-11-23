using System;

    class Program
    {
        static void Main()
        {
            //Input
            decimal N = decimal.Parse(Console.ReadLine());
            decimal M = decimal.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());

            //Calculate
            decimal mathExpression = 0.0m;
            mathExpression = (((N * N) + (1 / (M * P)) + 1337) / (N - (128.523123123m * P))) + (decimal)(Math.Sin((int)M % 180));
            
            //Output
            Console.WriteLine("{0:0.000000}",mathExpression);
        }
    }

