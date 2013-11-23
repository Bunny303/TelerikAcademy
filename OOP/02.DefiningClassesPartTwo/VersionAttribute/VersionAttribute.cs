[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct |
                       System.AttributeTargets.Enum |
                       System.AttributeTargets.Method)]

public class VersionAttribute : System.Attribute
{
    public double Version { get; private set; }

    public VersionAttribute(double version)
    {
        this.Version = version;
    }
}