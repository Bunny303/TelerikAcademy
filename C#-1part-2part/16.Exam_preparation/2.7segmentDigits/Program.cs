using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{

    static void Main()
    {
        byte[] digits = 
        {
            Convert.ToByte("1111110", 2),
            Convert.ToByte("0110000", 2),
            Convert.ToByte("1101101", 2),
            Convert.ToByte("1111001", 2),
            Convert.ToByte("0110011", 2),
            Convert.ToByte("1011011", 2),
            Convert.ToByte("1011111", 2),
            Convert.ToByte("1110000", 2),
            Convert.ToByte("1111111", 2),
            Convert.ToByte("1111011", 2)
        };
        
        int N = int.Parse(Console.ReadLine());
        byte[] inputNumbers = new byte[N];
        
        for (int i = 0; i < N; i++)
        {
            inputNumbers[i] = Convert.ToByte(Console.ReadLine(), 2);
        }
        FindCombinations(inputNumbers, digits, 0, N);

        
    }

    static void FindCombinations(byte[] inputNumbers, byte[] digits, int position, int N)
    {
        
        char[] currentAnswer = new char[N];

        if (position == N)
        {
            for (int i = 0; i < currentAnswer.Length; i++)
            {
                Console.Write(currentAnswer[i]);
            }
            return; 
        }
        for (int i = 0; i < digits.Length; i++)
        {
            if ((digits[i] & inputNumbers[position]) == inputNumbers[position])
            {
                currentAnswer[position] = (char)('0' + i);
                FindCombinations(inputNumbers, digits, position+1, N);
            }
        }
        
    }

   
       
}