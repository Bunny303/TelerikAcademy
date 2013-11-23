using System;
using System.Text;

// 1.Define structure
public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    // 2 Define static read only field
    static private readonly Point3D zeroPoint = new Point3D(0, 0, 0);

    // 2. Define static property 
    static public Point3D ZeroPoint
    {
        get { return zeroPoint; }
    }
    
    public Point3D(int x, int y, int z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    
    public override string ToString()
    {
        StringBuilder printResult = new StringBuilder();
        printResult.AppendFormat("({0}, ", this.X.ToString());
        printResult.AppendFormat("{0}, ", this.Y.ToString());
        printResult.AppendFormat("{0})", this.Z.ToString());
        return printResult.ToString();
    }
}