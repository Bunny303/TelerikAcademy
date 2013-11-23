using System;

class Exercises1to4
    {
        static void Main()
        {
            // Chck if number is odd or even
            Console.Write("Write a number:");
            int Number = int.Parse(Console.ReadLine());
            int NumberOddEven = Number % 2;
            if (NumberOddEven == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            // Check if number can be divided by 7 and 5
            int Numberdiv5and7 = Number % 35;
            if (Numberdiv5and7 == 0)
            {
                Console.WriteLine("The number can be divided by 7 and 5");
            }
            else
            {
                Console.WriteLine("The number can't be divided by 7 and 5");
            }

            // Calculates rectangle’s area
            Console.Write("Write a width of rectangle:");
            int Width = int.Parse(Console.ReadLine());
            Console.Write("Write a height of rectangle:");
            int Height = int.Parse(Console.ReadLine());
            double Area = (Width * Height) / 2.0;
            Console.WriteLine("The rectangle's area is:{0}", Area);


            // Checks if the third digit from given number (right-to-left) is 7
            Console.Write("Insert a number:");
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int numberdiv100 = number / 100;
            int nuberdiv10 = numberdiv100 % 10;
            if (nuberdiv10 == 7)
            {
                Console.WriteLine("The third digit from given number (right-to-left) is 7");
            }
            else
            {
                Console.WriteLine("The third digit from given number (right-to-left) is NOT 7");
            }

                       
        }
    }
