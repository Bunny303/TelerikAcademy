//5. Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Globalization;

class Workdays
{
    string[] publicHolidays = { 01 - 01, 03 - 03, 25 - 12 };
    string pattern = "dd-MM";
    DateTime parsedDate;

    static void Main()
    {

    }

    static int CalculateWorkdays(DateTime inputDate)
    {
        int workdays = 0;


        return workdays;
    }
}
