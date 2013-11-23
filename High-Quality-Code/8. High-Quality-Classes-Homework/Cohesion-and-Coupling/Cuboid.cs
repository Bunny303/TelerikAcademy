using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public static class Cuboid
    {
        private static double width;
        private static double height;
        private static double depth;

        public static double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Width must be positive!");
                }
            }
        }

        public static double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height must be positive!");
                }
            }
        }

        public static double Depth
        {
            get { return depth; }
            set
            {
                if (value > 0)
                {
                    depth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Depth must be positive!");
                }
            }
        }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }
    }
}
