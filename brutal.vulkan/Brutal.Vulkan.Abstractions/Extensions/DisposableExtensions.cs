namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Provides extension methods for IDisposable objects.
/// </summary>
public static class DisposableExtensions
{
    /// <summary>
    /// Disposes each element in the provided span.
    /// </summary>
    /// <typeparam name="T">The type of IDisposable objects.</typeparam>
    /// <param name="inObjects">The span of IDisposable objects to dispose.</param>
    public static void Dispose<T>(this Span<T> inObjects)
        where T : IDisposable
    {
        foreach (var obj in inObjects)
            obj.Dispose();
    }

    /// <summary>
    /// Disposes each element in the provided array.
    /// </summary>
    /// <typeparam name="T">The type of IDisposable objects.</typeparam>
    /// <param name="inObjects">The array of IDisposable objects to dispose.</param>
    public static void Dispose<T>(this T[] inObjects)
        where T : IDisposable
    {
        foreach (var obj in inObjects)
            obj.Dispose();
    }

    /// <summary>
    /// Disposes each element in the provided enumerable collection.
    /// </summary>
    /// <typeparam name="T">The type of IDisposable objects.</typeparam>
    /// <param name="inObjects">The enumerable collection of IDisposable objects to dispose.</param>
    public static void Destroy<T>(this IEnumerable<T> inObjects)
        where T : IDisposable
    {
        using var enumerator = inObjects.GetEnumerator();

        while (enumerator.MoveNext())
            enumerator.Current.Dispose();
    }
}
