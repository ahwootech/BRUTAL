using Brutal.Numerics;

namespace Brutal.Maths;

/// <summary>
///     Extension class providing additional methods for Random
/// </summary>
public static class RandomExtensions
{
    /// <summary>
    ///     Returns the next value that is greater than or equal to 0 and less than the specified maximum value.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="maxValue">The exclusive upper bound of the random number returned.</param>
    /// <exception cref="ArgumentOutOfRangeException">maxValue is less than 0.</exception>
    public static float NextSingle(this Random random, float maxValue)
    {
        if (maxValue < 0)
            throw new ArgumentOutOfRangeException(nameof(maxValue), @"maxValue must be greater than or equal to 0");

        return random.NextSingle() * maxValue;
    }

    /// <inheritdoc cref="NextSingle(System.Random, float)" />
    public static double NextDouble(this Random random, double maxValue)
    {
        if (maxValue < 0)
            throw new ArgumentOutOfRangeException(nameof(maxValue), @"maxValue must be greater than or equal to 0");

        return random.NextDouble() * maxValue;
    }

    /// <summary>
    ///     Returns the next value that is greater than or equal to a specified minimum value and less than a specified maximum
    ///     value.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
    /// <param name="maxValue">The exclusive upper bound of the random number returned.</param>
    /// <exception cref="ArgumentOutOfRangeException">minValue is greater than maxValue.</exception>
    public static float NextSingle(this Random random, float minValue, float maxValue)
    {
        if (minValue > maxValue)
            throw new ArgumentOutOfRangeException(nameof(minValue), @"minValue must be less than or equal to maxValue");

        return random.NextSingle() * (maxValue - minValue) + minValue;
    }

    /// <inheritdoc cref="NextSingle(System.Random, float, float)" />
    public static double NextDouble(this Random random, double minValue, double maxValue)
    {
        if (minValue > maxValue)
            throw new ArgumentOutOfRangeException(nameof(minValue), @"minValue must be less than or equal to maxValue");

        return random.NextDouble() * (maxValue - minValue) + minValue;
    }

    /// <summary>
    ///     Generates a random point within a uniform 2D square of the specified length.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="xySize">The uniform length of one side of the square. Defaults to 1. Must be greater than or equal to 0.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the length is less than 0.</exception>
    public static float2 NextSinglePointInSquare(this Random random, float xySize = 1)
    {
        return random.NextSinglePointInRectangle(xySize, xySize);
    }

    /// <inheritdoc cref="NextSinglePointInSquare" />
    public static double2 NextDoublePointInSquare(this Random random, double xySize = 1)
    {
        return random.NextDoublePointInRectangle(xySize, xySize);
    }

    /// <summary>
    ///     Generates a random point within a 2D rectangle of the specified length and width.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="xSize">The length of the rectangle. Must be greater than or equal to 0.</param>
    /// <param name="ySize">The width of the rectangle. Must be greater than or equal to 0.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the length or width is less than 0.</exception>
    public static float2 NextSinglePointInRectangle(this Random random, float xSize, float ySize)
    {
        return new float2(random.NextSingle(xSize), random.NextSingle(ySize));
    }

    /// <inheritdoc cref="NextSinglePointInRectangle" />
    public static double2 NextDoublePointInRectangle(this Random random, double xSize, double ySize)
    {
        return new double2(random.NextDouble(xSize), random.NextDouble(ySize));
    }

    /// <summary>
    ///     Generates a random point within a uniformly-sized 3D box of the specified length.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="xyzSize">The uniform length of all box sides. Defaults to 1. Must be greater than or equal to 0.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the length is less than 0.</exception>
    public static float3 NextSinglePointInBox(this Random random, float xyzSize = 1)
    {
        return random.NextSinglePointInBox(xyzSize, xyzSize, xyzSize);
    }

    /// <inheritdoc cref="NextSinglePointInBox(Random, float)" />
    public static double3 NextDoublePointInBox(this Random random, double xyzSize = 1)
    {
        return random.NextDoublePointInBox(xyzSize, xyzSize, xyzSize);
    }

    /// <summary>
    ///     Generates a random point within a 3D box of the specified length, width, and height.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="xSize">The length of the X dimension. Must be greater than or equal to 0.</param>
    /// <param name="ySize">The length of the Y dimension. Must be greater than or equal to 0.</param>
    /// <param name="zSize">The length of the Z dimension. Must be greater than or equal to 0.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the length is less than 0.</exception>
    public static float3 NextSinglePointInBox(this Random random, float xSize, float ySize, float zSize)
    {
        return new float3(random.NextSingle(xSize), random.NextSingle(ySize), random.NextSingle(zSize));
    }

    /// <inheritdoc cref="NextSinglePointInBox(Random, float, float, float)" />
    public static double3 NextDoublePointInBox(this Random random, double xSize, double ySize, double zSize)
    {
        return new double3(random.NextDouble(xSize), random.NextDouble(ySize), random.NextDouble(zSize));
    }

    /// <summary>
    ///     Generates a random point within a 2D circle of the specified radius.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="radius">The radius of the circle. Defaults to 1.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the radius is less than 0.</exception>
    public static float2 NextSinglePointInCircle(this Random random, float radius = 1)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), @"radius must be greater than or equal to 0");

        var r = float.Sqrt(random.NextSingle()) * radius;
        return r * random.NextSingleUnit2();
    }

    /// <inheritdoc cref="NextSinglePointInCircle" />
    public static double2 NextDoublePointInCircle(this Random random, double radius = 1)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), @"radius must be greater than or equal to 0");

        var r = double.Sqrt(random.NextDouble()) * radius;
        return r * random.NextDoubleUnit2();
    }

    /// <summary>
    ///     Generates a random point within a 3D sphere of the specified radius.
    /// </summary>
    /// <param name="random">The random number generator.</param>
    /// <param name="radius">The radius of the sphere. Defaults to 1.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the radius is less than 0.</exception>
    public static float3 NextSinglePointInSphere(this Random random, float radius = 1)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), @"radius must be greater than or equal to 0");

        var r = float.Sqrt(random.NextSingle()) * radius;
        return r * random.NextSingleUnit3();
    }

    /// <inheritdoc cref="NextSinglePointInSphere" />
    public static double3 NextDoublePointInSphere(this Random random, double radius = 1)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), @"radius must be greater than or equal to 0");

        var r = double.Sqrt(random.NextDouble()) * radius;
        return r * random.NextDoubleUnit3();
    }

    /// <summary>
    ///     Generates a random 2D unit vector
    /// </summary>
    /// <param name="random">The random number generator.</param>
    public static float2 NextSingleUnit2(this Random random)
    {
        var theta = random.NextSingle(float.Tau);
        return new float2(float.Cos(theta), float.Sin(theta));
    }

    /// <inheritdoc cref="NextSingleUnit2" />
    public static double2 NextDoubleUnit2(this Random random)
    {
        var theta = random.NextDouble(float.Tau);
        return new double2(double.Cos(theta), double.Sin(theta));
    }

    /// <summary>
    ///     Generates a random 3D unit vector
    /// </summary>
    /// <param name="random">The random number generator.</param>
    public static float3 NextSingleUnit3(this Random random)
    {
        var theta = random.NextSingle(float.Tau);
        var phi = random.NextSingle(float.Pi);
        return new float3(float.Sin(phi) * float.Cos(theta), float.Sin(phi) * float.Sin(theta), float.Cos(phi));
    }

    /// <inheritdoc cref="NextSingleUnit3" />
    public static double3 NextDoubleUnit3(this Random random)
    {
        var theta = random.NextDouble(double.Tau);
        var phi = random.NextDouble(double.Pi);
        return new double3(double.Sin(phi) * double.Cos(theta), double.Sin(phi) * double.Sin(theta), double.Cos(phi));
    }
}
