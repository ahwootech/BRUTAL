namespace Brutal;

/// <summary>
/// Interface for a type that can be null
/// </summary>
public interface INullable
{
    /// <summary>
    /// Returns true if the instance is null
    /// </summary>
    public bool IsNull();
}

/// <summary>
/// Extensions for INullable
/// </summary>
public static class NullableExtensions
{
    /// <summary>
    /// Returns true if the instance is not null
    /// </summary>
    public static bool IsNotNull<T>(this T nullable)
        where T : INullable
    {
        return !nullable.IsNull();
    }
}
