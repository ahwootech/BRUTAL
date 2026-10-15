namespace Brutal.Localization;

/// <summary>
/// Strongly typed id for a LString created from a string or ReadOnlySpan{char}.
/// LStringId objects are case-sensitive.
/// The strings or ReadOnlySpans passed to the constructor cannot be null or empty.
/// </summary>
public readonly record struct LStringId
{
    /// <summary>
    /// Helper to create a LStringId from a string.
    /// </summary>
    /// <param name="id">The case-sensitive string version of the id.</param>
    /// <returns>The created LStringId.</returns>
    /// <exception cref="ArgumentException">Thrown if id is null or empty.</exception>
    public static LStringId From(string id)
    {
        return new LStringId(id);
    }

    /// <summary>
    /// Create a LStringId from a ReadOnlySpan.
    /// </summary>
    /// <remarks>NOTE: LStringId objects are case-insensitive.</remarks>
    /// <param name="id">The ReadOnlySpan of chars of the LStringId to create.</param>
    /// <exception cref="ArgumentException">Thrown if the ReadOnlySpan is empty.</exception>
    public LStringId(ReadOnlySpan<char> id)
    {
        if (id.IsEmpty)
            throw new ArgumentException($"Invalid LStringId '{id}'", nameof(id));

        _value = id.ToString();
    }

    /// <summary>
    /// Create a LStringId from a string.
    /// </summary>
    /// <param name="id">The case-sensitive string to use for the LStringId.</param>
    /// <exception cref="ArgumentException">Thrown if id is null or empty.</exception>
    public LStringId(string id)
    {
        if (string.IsNullOrEmpty(id))
            throw new ArgumentException($"Invalid LStringId '{id}'");

        _value = id;
    }

    /// <summary>
    /// The string value of the LStringId.
    /// </summary>
    public override string ToString() => _value;

    private readonly string _value;
}
