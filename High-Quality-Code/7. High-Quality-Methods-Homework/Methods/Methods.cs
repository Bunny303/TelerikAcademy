using System;

namespace Methods
{
    class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return area;
        }

        public static string ConvertDigitToString(int number)
        {
            switch (number)
            {
                case 0: return "zero"; 
                case 1: return "one"; 
                case 2: return "two"; 
                case 3: return "three"; 
                case 4: return "four"; 
                case 5: return "five"; 
                case 6: return "six"; 
                case 7: return "seven"; 
                case 8: return "eight"; 
                case 9: return "nine"; 
                default: 
                    throw new ArgumentException ("Invalid input number!");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Input can not be null element!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentException("Input must have at least one element!");
            }

            var max = int.MinValue;
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[i-1])
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public static void PrintNumber(double value, int decimals)
        {
            string format = "{0:F" + decimals + "}";
            Console.WriteLine(format, value);
        }

        public static void PrintPercent(double value, int decimals)
        {
            string format = "{0:P" + decimals + "}";
            Console.WriteLine(format, value);
        }

        public static void PrintAligned(object value, int totalWidth)
        {
            string format = "{0," + totalWidth + "}";
            Console.WriteLine(format, value);
        }


        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
            return distance;
        }

        public static bool IsLineHorizontal(double x1, double y1, double x2, double y2)
        {
            return y1 == y2;
        }

        public static bool IsLineVertical(double x1, double y1, double x2, double y2)
        {
            return x1 == x2;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(ConvertDigitToString(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumber(1.3, 2);
            PrintPercent(0.75, 5);
            PrintAligned(2.30, 4);

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine(IsLineHorizontal(3, -1, 3, 2.5));
            Console.WriteLine(IsLineVertical(3, -1, 3, 2.5));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.Info = new PersonalInformation("17.03.1992", "Sofia");

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.Info = new PersonalInformation("03.11.1993", "Varna", "gamer");

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
