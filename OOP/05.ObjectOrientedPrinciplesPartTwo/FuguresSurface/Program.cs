using System;
using System.Linq;

namespace FuguresSurface
{
    class Program
    {
        static void Main()
        {
            Shape[] myShapes = new Shape[3];
            myShapes[0] = new Rectangle(3, 5);
            myShapes[1] = new Triangle(2, 8);
            myShapes[2] = new Circle(5);

            foreach (var shape in myShapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
