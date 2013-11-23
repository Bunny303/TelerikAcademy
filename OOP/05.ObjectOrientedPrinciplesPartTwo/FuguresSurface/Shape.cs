using System;
using System.Linq;

namespace FuguresSurface
{
    abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        public abstract double CalculateSurface();
    }
}
