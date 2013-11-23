using System;
using System.Linq;

namespace FuguresSurface
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        { }
        
        public override double CalculateSurface()
        {
            return Math.Round(base.Height * base.Width,2);
        }
    }
}
