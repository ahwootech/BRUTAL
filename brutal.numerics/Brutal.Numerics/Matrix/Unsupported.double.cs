// ReSharper disable InconsistentNaming

namespace Brutal.Numerics;

// These types are not well-supported in Brutal, yet.
// They are provided for completeness, but they may not have full functionality.
// FEEL FREE TO IMPLEMENT THEM IF YOU NEED THEM

public struct double2x2(double2 x, double2 y)
{
    public static readonly double2x2 Identity = new(new(1, 0), new(0, 1));

    public double2 X = x;
    public double2 Y = y;
}

public struct double3x3(double3 x, double3 y, double3 z)
{
    public static readonly double3x3 Identity = new(new(1, 0, 0), new(0, 1, 0), new(0, 0, 1));

    public double3 X = x;
    public double3 Y = y;
    public double3 Z = z;
}

public struct double2x3(double2 x, double2 y, double2 z)
{
    public double2 X = x;
    public double2 Y = y;
    public double2 Z = z;
}

public struct double2x4(double4 x, double4 y)
{
    public double4 X = x;
    public double4 Y = y;
}

public struct double4x2(double2 x, double2 y, double2 z, double2 w)
{
    public double2 X = x;
    public double2 Y = y;
    public double2 Z = z;
    public double2 W = w;
}

public struct double3x4(double4 x, double4 y, double4 z)
{
    public double4 X = x;
    public double4 Y = y;
    public double4 Z = z;
}

public struct double4x3(double3 x, double3 y, double3 z, double3 w)
{
    public double3 X = x;
    public double3 Y = y;
    public double3 Z = z;
    public double3 W = w;
}
