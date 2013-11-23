using System;
using System.Linq;

namespace FuguresSurface
{
    class Circle :Shape
    {
        public Circle(double height)
            : base(height, height)
        {
        }
        
        public override double CalculateSurface()
        {
            return Math.Round(Math.PI*(base.Height/2)*(base.Height/2), 2);
        }
    }
}
