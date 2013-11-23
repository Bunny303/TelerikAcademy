// 18. Write a program for extracting all email addresses from given text. All substrings that match the format 
// <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmail
{
    static void Main()
    {
        string text = "Bunitaaaa  talala@abv.bg and more bunniessssss and again blabla@boom.moon ab@co.uk";

        string pattern = @"([a-z0-9_.-]+)@([\da-z-]+)\.([a-z]){2,6}";
        var emails = Regex.Matches(text, pattern);

        foreach (Match email in emails)
        {
            Console.WriteLine(email);
        }
        
    }
}
