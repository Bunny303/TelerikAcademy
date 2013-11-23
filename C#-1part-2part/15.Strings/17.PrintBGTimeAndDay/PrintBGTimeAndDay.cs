// 17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 
using System;
using System.Globalization;

class PrintBGTimeAndDay
{
    static void Main()
    {
        //Console.Write("Enter date and time /day.month.year hour:minute:second/: ");
        //string input = Console.ReadLine();

        string input = "26.01.2013 19:25:46";
        
        DateTime date = DateTime.ParseExact(input, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6).AddMinutes(30);
        Console.WriteLine("Date and time:{0}, Day of the week: {1}", date, date.ToString("dddd", CultureInfo.CreateSpecificCulture("bg-BG")));
    }
}
