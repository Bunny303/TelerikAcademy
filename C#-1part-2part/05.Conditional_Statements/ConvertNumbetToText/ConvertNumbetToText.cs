//Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation
using System;

    class ConvertNumbetToText
    {
        static void Main()
        {
            //Input and read number
            Console.Write("Please enter a number in range [0..999]: ");
            int inputNumber = int.Parse(Console.ReadLine());

            //Divide the number of hundreds, tens and units and stores it in the variables
            int hundreds = inputNumber / 100;
            int tens = (inputNumber % 100) / 10;
            int units = (inputNumber % 100) % 10;

            // Check hudreds and print result
            switch (hundreds)
            {
                case 0: break;
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
                default: Console.WriteLine("Wrong input number "); break;
            }

            //check tens and print

            if (tens > 1) 
            {
                switch (tens)
                {
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                    default: Console.Write("Wrong input number"); break;
                }
                switch (units)
                {
                    case 0: break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    default: Console.WriteLine("Wrong input number "); break;
                }
            }

            else if (tens == 0)
            {
                if (hundreds != 0)
                {
                    switch (units)
                    {
                        case 0: break;
                        case 1: Console.WriteLine("and one"); break;
                        case 2: Console.WriteLine("and two"); break;
                        case 3: Console.WriteLine("and three"); break;
                        case 4: Console.WriteLine("and four"); break;
                        case 5: Console.WriteLine("and five"); break;
                        case 6: Console.WriteLine("and six"); break;
                        case 7: Console.WriteLine("and seven"); break;
                        case 8: Console.WriteLine("and eight"); break;
                        case 9: Console.WriteLine("and nine"); break;
                        default: Console.WriteLine("Wrong input number "); break;
                    }
                }
                else
                {
                    switch (units)
                    {
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                        default: Console.WriteLine("zero"); ; break;
                    }
                }
            }
            else 
            {
                if (hundreds != 0)
                {
                    Console.Write("and ");
                }
                switch (units)
                    {
                        case 0: Console.WriteLine("ten"); break;
                        case 1: Console.WriteLine("eleven"); break;
                        case 2: Console.WriteLine("twelve"); break;
                        case 3: Console.WriteLine("thirteen"); break;
                        case 4: Console.WriteLine("fourteen"); break;
                        case 5: Console.WriteLine("fifteen"); break;
                        case 6: Console.WriteLine("sixteen"); break;
                        case 7: Console.WriteLine("seventeen"); break;
                        case 8: Console.WriteLine("eighteen"); break;
                        case 9: Console.WriteLine("nineteen"); break;
                        default: Console.WriteLine("Wrong input number "); break;
                    }    
                
                }
               
            
         
        }
    }

