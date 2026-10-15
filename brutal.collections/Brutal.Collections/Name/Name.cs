using System.Runtime.CompilerServices;

namespace Brutal.Collections;

/// <summary>
/// A pool-based (see: <see cref="Namespace{T}"/>) unique identifier for various entities in a system.
/// </summary>
public readonly struct Name<T> : IEquatable<Name<T>>
{
    /// <summary>
    /// The underlying string value of the Name.
    /// </summary>
    public readonly string Value;

    /// <summary>
    /// Construct a Name from a string, using the shared pool for the type T.
    /// </summary>
    public Name(string id)
        : this(id, Namespace<T>.Shared) { }

    /// <summary>
    /// Construct a Name from a string, using the given pool.
    /// </summary>
    public Name(string id, Namespace<T> pool)
    {
        Value = pool.GetOrAdd(id);
    }

    /// <summary>
    /// Get the underlying string value of the Name.
    /// </summary> public new string ToString() => Value;
    /// <summary>
    /// Checks equality with another Name, based on reference equality of the underlying string.
    /// </summary>
    public bool Equals(Name<T> other)
    {
        return ReferenceEquals(Value, other.Value);
    }

    /// <summary>
    /// Checks equality with another object.
    /// </summary>
    public override bool Equals(object? obj)
    {
        return obj is Name<T> other && Equals(other);
    }

    /// <summary>
    /// Calculates the hash code for the Name (based on the reference of the Value).
    /// </summary>
    public override int GetHashCode()
    {
        // Hash the reference of the Value for performance
        return RuntimeHelpers.GetHashCode(Value);
    }

    /// <summary>Equality operator for Name.</summary>
    public static bool operator ==(Name<T> left, Name<T> right)
    {
        return left.Equals(right);
    }

    /// <summary>Inequality operator for Name.</summary>
    public static bool operator !=(Name<T> left, Name<T> right)
    {
        return !left.Equals(right);
    }

    /// <summary>Equality operator for Name and string.</summary>
    public static bool operator ==(Name<T> left, string right)
    {
        return left.Value == right;
    }

    /// <summary>Inequality operator for Name and string.</summary>
    public static bool operator !=(Name<T> left, string right)
    {
        return left.Value != right;
    }

    /// <summary>Equality operator for string and Name.</summary>
    public static bool operator ==(string left, Name<T> right)
    {
        return left == right.Value;
    }

    /// <summary>Inequality operator for string and Name.</summary>
    public static bool operator !=(string left, Name<T> right)
    {
        return left != right.Value;
    }

    /// <summary>
    /// Implicitly construct a Name from a string.
    /// </summary>
    public static implicit operator Name<T>(string id) => new(id);

    /// <summary>
    /// Get the underlying string value of the Name.
    /// </summary>
    public override string ToString() => Value;
}
