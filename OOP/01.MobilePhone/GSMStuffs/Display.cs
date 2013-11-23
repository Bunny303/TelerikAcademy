using System;

namespace GSMStuffs
{
    // 1. Define class Display
    public class Display
    {
        public double? Size { get; set; } //automatic property
        public uint? Colors { get; set; } //automatic property

        // 2. Define parametless constructor
        public Display()
        { }
        
        // 2. Define constructor with all parameters
        public Display(double? size, uint? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}
