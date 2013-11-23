using System;
using System.Linq;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            // Define list
            GenericList<int> testList = new GenericList<int>(1);

            //Test method AddElement and auto grow functionality
            testList.AddElement(1);
            testList.AddElement(2);
            testList.AddElement(3);
            testList.AddElement(4);
            Console.WriteLine(testList);
            
            // Test method ReadElement
            Console.WriteLine("Element at position 2 is: {0}", testList.ReadElement(2));

            //Test method RemoveElement
            testList.RemoveElement(1);
            Console.WriteLine("After removing an element: {0}", testList);

            //Test method InsertElement
            testList.InsertElement(2, 111);
            Console.WriteLine("After inserting an element: {0}", testList);

            //Test method FindElemenetByValue
            Console.WriteLine("The element is at position: {0}", testList.FindElemenetByValue(111));

            // Test method Min<T>
            Console.WriteLine("Element with minimum value is: {0}",testList.Min());

            // Test method Max<T>
            Console.WriteLine("Element with maximum value is: {0}", testList.Max());

            //Test method ClearList
            testList.ClearList();
            Console.WriteLine("After clearing the list: {0}", testList);
        }
    }
}
