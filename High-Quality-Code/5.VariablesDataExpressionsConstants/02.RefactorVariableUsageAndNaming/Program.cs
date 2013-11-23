using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RefactorVariableUsageAndNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, 2, 3, 4, 5 };
            
        }

        public void PrintNumber(string description,double number)
        {
            Console.WriteLine("{0} number: {1}",description,number);
        }

        public void PrintArrayStatistics(double[] arr, int length)
        {
            double max = double.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            PrintNumber("Max", max);

            double min = double.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            PrintNumber("Min", min);

            double tmp = 0;
            for (int i = 0; i < length; i++)
            {
                tmp += arr[i];
            }
            double average = tmp / length;
            PrintNumber("Average", average);
        }
    }
}
