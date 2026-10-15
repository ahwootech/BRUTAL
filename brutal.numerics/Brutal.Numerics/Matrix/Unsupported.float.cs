// ReSharper disable InconsistentNaming

namespace Brutal.Numerics;

// These types are not well-supported in Brutal, yet.
// They are provided for completeness, but they may not have full functionality.
// FEEL FREE TO IMPLEMENT THEM IF YOU NEED THEM

public struct float2x2(float2 x, float2 y)
{
    public static readonly float2x2 Identity = new(new(1, 0), new(0, 1));

    public float2 X = x;
    public float2 Y = y;
}

public struct float3x3(float3 x, float3 y, float3 z)
{
    public static readonly float3x3 Identity = new(new(1, 0, 0), new(0, 1, 0), new(0, 0, 1));

    public float3 X = x;
    public float3 Y = y;
    public float3 Z = z;
}

public struct float2x3(float2 x, float2 y, float2 z)
{
    public float2 X = x;
    public float2 Y = y;
    public float2 Z = z;
}

public struct float2x4(float4 x, float4 y)
{
    public float4 X = x;
    public float4 Y = y;
}

public struct float4x2(float2 x, float2 y, float2 z, float2 w)
{
    public float2 X = x;
    public float2 Y = y;
    public float2 Z = z;
    public float2 W = w;
}

public struct float3x4(float4 x, float4 y, float4 z)
{
    public float4 X = x;
    public float4 Y = y;
    public float4 Z = z;
}

public struct float4x3(float3 x, float3 y, float3 z, float3 w)
{
    public float3 X = x;
    public float3 Y = y;
    public float3 Z = z;
    public float3 W = w;
}
