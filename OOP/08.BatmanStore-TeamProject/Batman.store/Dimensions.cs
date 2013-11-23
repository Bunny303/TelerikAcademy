using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public struct Dimensions
    {
        //fields
        private int width;
        private int height;
        private int depth;

        //constructor
        public Dimensions(int width, int height, int depth)
            : this()
        {

            //cant be lower than 0
            if (width > 0 && height > 0 && depth > 0)
            {

                this.width = width;
                this.height = height;
                this.depth = depth;
            }
            else
            {
                throw new ArgumentException("width, heidht and depth should be greater than 0");
            }
            

        }

        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(width);
            result.Append(" x ");
            result.Append(height);
            result.Append(" x ");
            result.Append(depth);
            return result.ToString();
        }
    }
}
