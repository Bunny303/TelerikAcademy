using System;

    class SolveOfQuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter the coefficient a: ");
            string CoefficientA = Console.ReadLine();
            float a = float.Parse(CoefficientA);
            
            Console.Write("Enter the coefficient b: ");
            string CoefficientB = Console.ReadLine();
            float b = float.Parse(CoefficientB);

            Console.Write("Enter the coefficient c: ");
            string CoefficientC = Console.ReadLine();
            float c = float.Parse(CoefficientC);

            double D=(b*b)-(4*a*c);
            if (D >= 0)
            {
                double x1 = ((-b) + (Math.Sqrt(D))) / (2 * a);
                double x2 = ((-b) - (Math.Sqrt(D))) / (2 * a);
                Console.WriteLine("The real roots of quadratic equation ax2+bx+c=0 are: x1={0:0.00}; x2={1:0.00}", x1, x2);
            }
            else
            {
                Console.WriteLine("There aren't real roots of quadratic equation ax2+bx+c=0");
            }
        }
    }

