//3. We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
//several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

using System;

class LongestSequenceOfEqualElements
{
    static void Main()
    {
        //string[,] matrix = 
        //{ 
        //    { "ha", "fifi", "ho", "hi" }, 
        //    { "fo", "ha", "hi", "xx" }, 
        //    { "xxx", "ho", "ha", "xx" } 
        //};

        //string[,] matrix = 
        //{
        //    { "s", "qq", "s" }, 
        //    { "pp", "pp", "s" }, 
        //    { "pp", "qq", "s" } 
        //};

        string[,] matrix = 
        {
            { "s", "qq", "ss" }, 
            { "pp", "ss", "s" }, 
            { "ss", "qq", "s" } 
        };

        int counter = 1;
        int maxCounter = 0;
        int maxRow = 0;
        int maxCol = 0;
               
        //Check for longest column
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxRow = row+1;
                        maxCol = col;
                    }
                }
            }
            counter = 1;
        }

        //Check for longest row
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxRow = row;
                        maxCol = col + 1;
                    }
                }
            }
            counter = 1;
        }

        //Check for longest right diagonal
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            { 
                for (int iCell = 0, jCell=0; iCell< (matrix.GetLength(0) - 1) && jCell < (matrix.GetLength(1) - 1); iCell++, jCell++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maxRow = row + 1;
                            maxCol = col + 1;
                        }
                    }    
                }
                counter = 1;
            }
        }
        
        //Check for longest left diagonal
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = matrix.GetLength(1) - 1; col < 0; col--)
            {
                for (int iCell = 0, jCell = matrix.GetLength(1) - 1; iCell < (matrix.GetLength(0) - 1) && jCell <= 0; iCell++, jCell--)
                {
                    if (matrix[row, col] == matrix[row + 1, col -1])
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maxRow = row + 1;
                            maxCol = col - 1;
                        }
                    }
                }
                counter = 1;
            }
        }

        //Print max sequence        
        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write(matrix[maxRow,maxCol]+" ");
        }
    }
}
