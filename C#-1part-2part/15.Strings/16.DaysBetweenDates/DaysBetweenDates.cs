// 16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string firstInput = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondInput = Console.ReadLine();

        //string firstInput = "27.02.2006";
        //string secondInput = "3.03.2006";

        DateTime firstDate = DateTime.ParseExact(firstInput, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(secondInput, "d.MM.yyyy", CultureInfo.InvariantCulture);

        int days = (int)(secondDate - firstDate).TotalDays;
        Console.WriteLine("Distance: {0} days", days);
    }
}
