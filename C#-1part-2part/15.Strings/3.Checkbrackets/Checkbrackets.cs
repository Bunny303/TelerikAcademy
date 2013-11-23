// 3. Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Collections.Generic;
using System.Text;

class Checkbrackets
{
    static void Main()
    {
        string input = "((a+b)/5-d)";
        //string input = ")(a+b))";

        if (IsBracketsCorrect(input))
        {
            Console.WriteLine("The brackets are correct");
        }
        else
        {
            Console.WriteLine("The brackets are incorrect");
        }
    }

    static bool IsBracketsCorrect(string input)
    {
        int brackets = 0;
        bool result = false;

        foreach (char ch in input)
        {
            if (brackets >= 0)
            {
                if (ch == '(')
                {
                    brackets++;
                }
                if (ch == ')')
                {
                    brackets--;
                }
            }
            else
            {
                break;
            }
        }
        if (brackets == 0)
        {
            result = true;
        }
        return result;
    }
}
