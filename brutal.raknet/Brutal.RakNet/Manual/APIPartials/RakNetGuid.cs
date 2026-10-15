namespace Brutal.RakNetApi;

public partial struct RakNetGUID : IEquatable<RakNetGUID>
{
    /// <summary>
    /// A special RakNetGUID used in the API.
    /// </summary>
    /// <remarks>
    /// UNASSIGNED_RAKNET_GUID is often means for concepts like "MY GUID" or "ANY GUID"
    /// </remarks>
    public static readonly RakNetGUID UNASSIGNED_RAKNET_GUID = new()
    {
        G = ulong.MaxValue,
        SystemIndex = ushort.MaxValue,
    };

    /// <summary>
    /// Converts the current <see cref="RakNetGUID"/> instance to its string representation.
    /// </summary>
    /// <returns>A string representation of the <see cref="RakNetGUID"/> instance. Returns "UNASSIGNED_RAKNET_GUID" if the instance is equal to <see cref="UNASSIGNED_RAKNET_GUID"/>, otherwise returns the value of the G field as a string.</returns>
    public override string ToString()
    {
        return this == UNASSIGNED_RAKNET_GUID ? "UNASSIGNED_RAKNET_GUID" : $"{G}";
    }

    /// <summary>
    /// Defines an equality operator for comparing two instances of <see cref="RakNetGUID"/>.
    /// </summary>
    /// <param name="left">The first <see cref="RakNetGUID"/> instance to compare.</param>
    /// <param name="right">The second <see cref="RakNetGUID"/> instance to compare.</param>
    /// <returns>True if the two instances are equal; otherwise, false.</returns>
    public static bool operator ==(RakNetGUID left, RakNetGUID right) => left.G == right.G;

    /// <summary>
    /// Defines an equality operator for comparing two instances of <see cref="RakNetGUID"/>.
    /// </summary>
    /// <param name="left">The first <see cref="RakNetGUID"/> instance to compare.</param>
    /// <param name="right">The second <see cref="RakNetGUID"/> instance to compare.</param>
    /// <returns>True if the two instances are equal; otherwise, false.</returns>
    public static bool operator !=(RakNetGUID left, RakNetGUID right) => !(left == right);

    /// <summary>
    /// Determines whether the current instance is equal to another instance of <see cref="RakNetGUID"/>.
    /// </summary>
    /// <param name="other">The <see cref="RakNetGUID"/> instance to compare with the current instance.</param>
    /// <returns>True if the current instance is equal to the specified instance; otherwise, false.</returns>
    public bool Equals(RakNetGUID other)
    {
        return G == other.G;
    }

    /// <summary>
    /// Determines whether the current instance is equal to a specified object.
    /// </summary>
    /// <param name="obj">The object to compare with the current instance.</param>
    /// <returns>True if the specified object is equal to the current instance; otherwise, false.</returns>
    public override bool Equals(object? obj)
    {
        return obj is RakNetGUID other && Equals(other);
    }

    /// <summary>
    /// Generates a hash code for the current instance of <see cref="RakNetGUID"/> based on its field values.
    /// </summary>
    /// <returns>A hash code representing the current instance.</returns>
    public override int GetHashCode()
    {
        return G.GetHashCode();
    }
}
