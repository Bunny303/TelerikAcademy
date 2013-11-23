// 10. Write a program that extracts from given XML file all the text without the tags. 

using System;
using System.IO;

class TextWithoutTags
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../test.txt"))
        {
            for (int i; (i = reader.Read()) != -1; ) 
            {
                if (i == '>') 
                {
                    string text = String.Empty;

                    while ((i = reader.Read()) != -1 && i != '<')
                    {
                        text += (char)i;
                    }

                    if (!String.IsNullOrWhiteSpace(text))
                    {
                        Console.WriteLine(text.Trim());
                    }
                }
            }
        }
    }
}
