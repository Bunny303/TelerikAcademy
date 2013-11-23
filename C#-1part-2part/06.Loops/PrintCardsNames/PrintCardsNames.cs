//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

using System;

    class PrintCardsNames
    {
        static void Main()
        {
            for (int i = 1; i < 14; i++)
            {

                for (int j = 1; j < 5; j++)
                {
                    switch (i)
                    {
                        case 1: Console.Write("Deuce of");
                            break;
                        case 2: Console.Write("Three of");
                            break;
                        case 3: Console.Write("Four of");
                            break;
                        case 4: Console.Write("Five of");
                            break;
                        case 5: Console.Write("Six of");
                            break;
                        case 6: Console.Write("Seven of");
                            break;
                        case 7: Console.Write("Eight of");
                            break;
                        case 8: Console.Write("Nine of");
                            break;
                        case 9: Console.Write("Ten of");
                            break;
                        case 10: Console.Write("Jack of");
                            break;
                        case 11: Console.Write("Queen of");
                            break;
                        case 12: Console.Write("King of");
                            break;
                        case 13: Console.Write("Ace of");
                            break;
                        default: break;
                    }

                    switch (j)
                    {
                        case 1: Console.Write(" spades");
                            break;
                        case 2: Console.Write(" hearts");
                            break;
                        case 3: Console.Write(" diamonds");
                            break;
                        case 4: Console.Write(" clubs");
                            break;
                        default: break;
                    }
                    
                    Console.WriteLine();
                }

            }

        }
    }

