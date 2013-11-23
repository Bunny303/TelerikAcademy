//3. Write a method that s the last digit of given integer as an English word. 
//Examples: 512 --> "two", 1024 --> "four", 12309 --> "nine".

using System;

class LastDigit
{
    static void Main()
    {
        //string lastDigit = LastDigitString(256);
        //Console.WriteLine(lastDigit);
    }

    static string LastDigitString(int inputNumber)
    {
        string lastDigit = "";
        inputNumber = inputNumber % 10;
        
        switch (inputNumber)
        {
            case 0:  lastDigit = "zero";  break;
            case 1:  lastDigit = "one";  break; 
            case 2:  lastDigit = "two";  break; 
            case 3:  lastDigit = "three";  break;
            case 4:  lastDigit = "four";  break;
            case 5:  lastDigit = "five";  break;
            case 6:  lastDigit = "six";  break;
            case 7:  lastDigit = "seven";  break;
            case 8:  lastDigit = "eight";  break;
            case 9:  lastDigit = "nine";  break;
            default:  break; 
        }
        return lastDigit;
    }
}
