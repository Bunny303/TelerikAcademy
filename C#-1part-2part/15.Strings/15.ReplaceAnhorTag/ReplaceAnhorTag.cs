// 15. Write a program that replaces in a HTML document given as string all the tags 
// <a href="…">…</a> with corresponding tags [URL=…]…[/URL].
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceAnhorTag
{
    static void Main()
    {
        string html = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        string pattern = @"<a href=""";
        string newPattern = @"[URL=";
        html = Regex.Replace(html, pattern, newPattern);
        
        pattern = @""">";
        newPattern = @"]";
        html = Regex.Replace(html, pattern, newPattern);

        pattern = @"</a>";
        newPattern = @"[/URL]";
        html = Regex.Replace(html, pattern, newPattern);

        Console.WriteLine(html);
        
    }
}