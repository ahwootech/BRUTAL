/*
 * HelloNumerics
 *
 * Vector and matrix basics: float3 arithmetic, dot/cross products and transforming by a float4x4.
 */

#:package Ahwoo.Brutal.Numerics@2026.10.2

// RIAN: This package current contains a mirror of the System.Numerics math library for compatibility in porting, but will be reduced
//       to only the types in a future release. Math libraries are opinionated and should be picked by the developer, not the framework.

using Brutal.Numerics;

var a = new float3(1, 0, 0);
var b = new float3(0, 1, 0);

Console.WriteLine($"a + b       = {a + b}");
Console.WriteLine($"a * 3       = {a * 3}");
Console.WriteLine($"dot(a, b)   = {float3.Dot(a, b)}");
Console.WriteLine($"cross(a, b) = {float3.Cross(a, b)}");
Console.WriteLine($"|a + b|     = {(a + b).Length()}");

// Rotate 90 degrees around Z, then move 10 units along X.
var transform = float4x4.CreateRotationZ(MathF.PI / 2) * float4x4.CreateTranslation(10, 0, 0);
Console.WriteLine($"transformed = {float3.Transform(a, transform)}");

var size = new int2(640, 480);
Console.WriteLine($"int2 size   = {size}");
