// ReSharper disable InconsistentNaming

namespace Brutal.Numerics;

/// <summary>Defines a generic plane type.</summary>
/// <typeparam name="TSelf">The type that implements the interface.</typeparam>
/// <typeparam name="TVectorType">The normal vector type</typeparam>
/// <typeparam name="T">The component type.</typeparam>
public interface IPlane<TSelf, TVectorType, T> : IEquatable<TSelf>, IFormattable
    where TSelf : IPlane<TSelf, TVectorType, T>
{
    public TVectorType Normal { get; }
    public T D { get; }

    /// <summary>Construct a plane of this type from a span (normal xyz, then d).</summary>
    static abstract TSelf Create(ReadOnlySpan<T> span);
}

internal class PlaneDebugView<TSelf, TVectorType, T>(IPlane<TSelf, TVectorType, T> p)
    where TSelf : IPlane<TSelf, TVectorType, T>
{
    /// <inheritdoc cref="Plane.Normal" />
    public TVectorType Normal => p.Normal;

    /// <inheritdoc cref="Plane.D" />
    public T D => p.D;

    public override string? ToString()
    {
        return p.ToString();
    }
}
