//3. Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;
using System.Collections.Generic;

class PrintTodayDay
{
    static void Main()
    {
        DateTime todayDate = DateTime.Today;
        Console.WriteLine(todayDate.DayOfWeek);
    }
}
