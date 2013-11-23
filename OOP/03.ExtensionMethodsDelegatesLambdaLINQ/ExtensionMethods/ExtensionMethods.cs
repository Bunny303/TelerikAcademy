using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        // 1.Define exetnsion method
        public static StringBuilder Substring(this StringBuilder inputString, int index, int lenght)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i <= index+lenght; i++)
            {
                result.Append(inputString[i]);
            }
            return result;
        }

        // 2. Define extension method - sum
        public static dynamic Sum<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = 0;
            foreach (T item in enumeration)
            {
                sum = sum + item;
            }

            return sum;
        }

        // 2. Define extension method - product
        public static dynamic Product<T>(this IEnumerable<T> enumeration)
        {
            dynamic product = 1;
            foreach (T item in enumeration)
            {
                product = product * item;
            }
            return product;
        }

        // 2. Define extension method - min 
        public static dynamic Min<T>(this IEnumerable<T> enumeration)
        {
            dynamic min = int.MaxValue;
            foreach (T item in enumeration)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }

        // 2. Define extension method - max
        public static dynamic Max<T>(this IEnumerable<T> enumeration)
        {
            dynamic max = int.MinValue;
            foreach (T item in enumeration)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        // 2. Define extension method - average. Try different way
        public static double Average<T>(this IEnumerable<T> enumeration)
        {
            double average = 0;
            int counter = 0;
            foreach (T item in enumeration)
            {
                average = average + Convert.ToDouble(item);
                counter++;
            }
            return average/counter;
        }
        
    }
}
