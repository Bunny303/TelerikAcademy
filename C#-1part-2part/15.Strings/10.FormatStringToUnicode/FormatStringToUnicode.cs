// 10. Write a program that converts a string to a sequence of C# Unicode character literals. 
// Use format strings. 

using System;
using System.Text;

class FormatStringToUnicode
{
    static void Main()
    {
        string input = "Hi!";

        foreach (char ch in input)
        {
            Console.Write("\\u{0:X4}", (int)ch);
        }
    }
}
