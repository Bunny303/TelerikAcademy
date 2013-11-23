using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = @"PRINT(Black and yellow, );
        PRINT(black and yellow,,);
        PRINT(black and yellow...);
        EXIT;";

        //StringBuilder inputCode = new StringBuilder();
        //while (true)
        //{
        //    string line = Console.ReadLine();
        //    inputCode.AppendLine(line);
        //    if (line.EndsWith("EXIT;")) break;
        //}
        //string input = inputCode.ToString();

        string pattern = @"PRINT\((.*\s)\)|FOR|EXIT";
        var matches = Regex.Matches(input, pattern);

        

        int counter = 1;

        foreach (Match match in matches)
        {
            switch (match.Value)
            {
                default:
                    {
                        for (int i = 0; i < counter; i++)
                        {
                            Console.Write(match.Groups[1].Value);
                        }
                        counter = 1;
                        
                    }
                    break;
                case "FOR":
                    {
                        string patOne = @"FOR\((.*\d),(.*\d)\)";
                        if (Regex.Match(input, patOne).Success)
                        {
                            counter = int.Parse(Regex.Match(input, patOne).Groups[2].Value) - int.Parse(Regex.Match(input, patOne).Groups[1].Value) + 1;    
                        }
                        else
                        {
                            string patTwo = @"FOR\((.*\d)\)";
                            counter = int.Parse(Regex.Match(input, patTwo).Groups[1].Value);
                        }
                        //counter *= counter;
                    }
                    break;
                case "EXIT": break;
            }
        }
    }
}

