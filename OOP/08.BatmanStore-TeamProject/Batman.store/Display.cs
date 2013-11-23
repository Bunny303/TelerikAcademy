using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Batman.store
{
    public struct Display
    {
        //fields
        private uint colors;
        private float size;

        
        //properties
        public uint Colors
        {
            get { return colors; }
            
        }

        public float Size
        {
            get { return size; }
            
        }

        //constructor
        public Display( uint colors, float size)
            :this()
        {
            this.colors = colors;
            this.size = size;
        }

    }
}
