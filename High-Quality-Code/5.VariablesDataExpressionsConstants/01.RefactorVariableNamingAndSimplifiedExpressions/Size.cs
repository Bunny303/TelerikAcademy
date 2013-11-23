using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RefactorVariableNamingAndSimplifiedExpressions
{
    public class FigureSize
    {
        private double width;

        public double Width
        {
            get { return width; }
            protected set 
            { 
                if (value > 0)
                {
                    width = value; 
                }
                else
                {
                    throw new ArgumentException("Width have to be positive!");
                }
            }
        }

        private double height;

        public double Height
        {
            get { return height; }
            protected set 
            { 
                if (value > 0)
                {
                    height = value; 
                }
                else
                {
                    throw new ArgumentException("Height have to be positive!");
                }
            }
        }
                
        public FigureSize(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static FigureSize GetRotatedFigureSize(FigureSize dimensionsOfFigure, double angleOfRotation)
        {
            double rotatedWidth = Math.Abs(Math.Cos(angleOfRotation)) * dimensionsOfFigure.Width + Math.Abs(Math.Sin(angleOfRotation)) * dimensionsOfFigure.Height;
            double rotatedHeight = Math.Abs(Math.Sin(angleOfRotation)) * dimensionsOfFigure.Width + Math.Abs(Math.Cos(angleOfRotation)) * dimensionsOfFigure.Height;
            FigureSize rotatedFigureSize = new FigureSize(rotatedWidth, rotatedHeight);
            return rotatedFigureSize;
        }
    }
}
