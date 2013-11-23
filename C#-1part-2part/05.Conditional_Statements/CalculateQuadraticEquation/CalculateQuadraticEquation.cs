//Write a program that enters the coefficients a, b and c of a quadratic equation
//		a*x2 + b*x + c = 0
//		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.


using System;

    class CalculateQuadraticEquation
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

            // Calculate D and real roots
            double D = (b * b) - (4 * a * c);
            double x1 = ((-b) + (Math.Sqrt(D))) / (2 * a);
            double x2 = ((-b) - (Math.Sqrt(D))) / (2 * a);

            //D > 0 there are 2 real roots
            if (D > 0)
            {
                Console.WriteLine("The real roots of quadratic equation ax2+bx+c=0 are: x1={0:0.00}; x2={1:0.00}", x1, x2);
            }
            // D < 0 there aren't real roots
            else if (D < 0)
            {
                Console.WriteLine("There aren't real roots of quadratic equation ax2+bx+c=0");
            }
            // D = 0  there is 1 real root
            else
            {
                Console.WriteLine("The real root of quadratic equation ax2+bx+c=0 is: x={0:0.00}", x1);
            }
        }
    }

