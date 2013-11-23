//11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//	x2 + 5 = 1x2 + 0x + 5 --> 501
//12. Extend the program to support also subtraction and multiplication of polynomials.

 
using System;

class Polinomials
{
    static void Main()
    {
        int[] firstCoeff = { 7, 5, 6, 1};
        int[] secondCoeff = { 1, 0, 9};
        AddTwoPolynomials(firstCoeff, secondCoeff);
        MultiplicationOfPolynomials(firstCoeff, secondCoeff);
        SubtractionOfPlynomials(firstCoeff, secondCoeff);
    }

    static void PrintPolynomial(int[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            if (i > 1)
            {
                if (array[i] != 0)
                {
                    if (array[i] == 1)
                    {
                        Console.Write("x{0} + ", i);
                    }
                    else
                    {
                        Console.Write("{0}x^{1} + ", array[i], i);
                    }
                }
            }
            else
            {
                if (array[i] != 0)
                {
                    if (array[i] == 1)
                    {
                        Console.Write("x + ");
                    }
                    else
                    {
                        Console.Write("{0}x + ", array[i]);
                    }
                }
            }

        }
        Console.WriteLine(array[0]);
    }
    
    static void AddTwoPolynomials(int[] firstCoeff, int[] secondCoeff)
    {
        //First polinomial
        PrintPolynomial(firstCoeff);

        //Second polinomial
        PrintPolynomial(secondCoeff);
    }

    static void MultiplicationOfPolynomials(int[] firstArray, int[] secondArray)
    {
        int[] coeffArray = new int [firstArray.Length*secondArray.Length];
        int[] powerArray = new int [firstArray.Length * secondArray.Length];

        int k=0;
        //Make one array to save coefficient and second to save powers of x
        for (int i = firstArray.Length - 1; i >= 0; i--)
        {
            for (int j = secondArray.Length - 1; j >= 0; j--)
            {
                coeffArray[k] = firstArray[i] * secondArray[j];
                powerArray[k] = i + j;
                k++;
            }
        }

        //Sum coefficient with same power of x
        for (int i = 0; i < powerArray.Length; i++)
        { 
            for (int j=i+1; j<powerArray.Length; j++)
            {
                if (powerArray[i] == powerArray[j])
                {
                    coeffArray[i] = coeffArray[i] + coeffArray[j];
                    coeffArray[j] = 0;
                }
            }
        }
        
        //Print result
        for (int i = 0; i < coeffArray.Length-1; i++)
        {
            if (coeffArray[i] != 0)
            {
                Console.Write("{0}x^{1} + ", coeffArray[i], powerArray[i]);
            }
        }
        Console.WriteLine(coeffArray[coeffArray.Length-1]);
    }

    static void SubtractionOfPlynomials(int[] firstArray, int[] secondArray)
    {
        // From longest array subtract the other one
        
        if (firstArray.Length>secondArray.Length)
        {
            int[] result = new int[firstArray.Length];
            for (int i = 0; i < secondArray.Length; i++)
            {
                result[i] = firstArray[i] - secondArray[i];
            }
            for (int i = secondArray.Length; i < firstArray.Length; i++)
            {
                result[i] = firstArray[i];
            }
            PrintPolynomial(result);
        }
        else
        {
            int[] result = new int[secondArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                result[i] = secondArray[i] - firstArray[i];
            }
            for (int i = firstArray.Length; i < secondArray.Length; i++)
            {
                result[i] = secondArray[i];
            }
            PrintPolynomial(result);
        }
    }
}
