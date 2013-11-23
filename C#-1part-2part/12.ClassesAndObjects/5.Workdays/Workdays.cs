//5. Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter a date YYYY/MM/DD: ");
        DateTime inputDate = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine(CalculateWorkdays(inputDate));
    }

    static int CalculateWorkdays(DateTime inputDate)
    {
        //Holidays
        DateTime[] holidays = 
        { 
            new DateTime(2013, 01, 01),
            new DateTime(2013, 05, 1), 
            new DateTime(2013, 05, 2), 
            new DateTime(2013, 05, 3),
            new DateTime(2013, 05, 6), 
            new DateTime(2013, 05, 24),                                         
            new DateTime(2013, 05, 25),
            new DateTime(2013, 02, 08),
        };

        DateTime todayDate = DateTime.Today;
        TimeSpan span = inputDate - todayDate;
        int workdays = span.Days + 1;
        int fullWeeks = workdays / 7;

        if (workdays > fullWeeks * 7) //If it's true there are non-full weeks between dates
        {
            int firstDayOfWeek;
            if (todayDate.DayOfWeek == DayOfWeek.Sunday)
            {
                firstDayOfWeek = 7;
            }
            else
            {
                firstDayOfWeek = (int)todayDate.DayOfWeek;
            }

            int lastDayOfWeek;
            if (inputDate.DayOfWeek == DayOfWeek.Sunday)
            {
                lastDayOfWeek = 7;
            }
            else
            {
                lastDayOfWeek = (int)inputDate.DayOfWeek;
            }
            
            if (lastDayOfWeek < firstDayOfWeek)
                lastDayOfWeek = lastDayOfWeek + 7;
            if (firstDayOfWeek <= 6)
            {
                if (lastDayOfWeek >= 7)// Add Saturday and Sunday
                {
                    workdays = workdays - 2;
                }
                else if (lastDayOfWeek >= 6)// Add only Saturday
                {
                    workdays = workdays - 1;
                }
            }
            else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Add only Sunday
            {
                workdays = workdays - 1;
            }
        }
        workdays = workdays - fullWeeks * 2; // subtract the full week's weekends
        
        //Subtract the public holidays
        foreach (DateTime holiday in holidays)
        {
            if (holiday >= todayDate && holiday <= inputDate)
            {
                workdays = workdays - 1;
            }
        }

        return workdays;
    }
}
