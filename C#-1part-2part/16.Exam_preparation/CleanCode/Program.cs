using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        StringBuilder input = new StringBuilder();
                for (int i = 0; i < N; i++)
        {
            input.Append(Console.ReadLine());
        }
        string code = input.ToString();

        string result = Regex.Replace(code, "/*(.*)*/", String.Empty);
        //string result = Regex.Replace(code, "//.*$", "");
        
        Console.WriteLine(result);
    }
}
