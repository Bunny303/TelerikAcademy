// 19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
// Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string text = "That's where the 2012 calendar end date comes in. 21.12.2012. Today date 26.01.2013";

        string pattern = @"\b\d{2}.\d{2}.\d{4}\b";
        var dates = Regex.Matches(text, pattern);

        DateTime date;
        foreach (Match dt in dates)
        {
            DateTime.TryParseExact(dt.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            string result = date.ToString("d", CultureInfo.CreateSpecificCulture("en-CA"));
            Console.WriteLine(result);
        }
    }       
               
}
