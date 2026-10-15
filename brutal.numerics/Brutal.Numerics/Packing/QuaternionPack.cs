using CommunityToolkit.HighPerformance;

namespace Brutal.Numerics;

/// <summary>
///     Packing utilities for converting between vector types
/// </summary>
public static class QuaternionPack
{
    /// <summary>
    ///     Convert a span of vectors of one type to another using a per-element delegate converter function
    /// </summary>
    /// <param name="source">Source span of vectors</param>
    /// <param name="destination">Destination span of vectors</param>
    /// <param name="elementConverter">Delegate for converting between source and destination elements</param>
    /// <typeparam name="TSourceType">Source element type</typeparam>
    /// <typeparam name="TDestinationElement">Destination element type</typeparam>
    /// <typeparam name="TSourceQuaternion">Source vector type</typeparam>
    /// <typeparam name="TDestinationQuaternion">Destination vector type</typeparam>
    /// <exception cref="ArgumentException">
    ///     Source and destination vector types have different element counts, or are different
    ///     length spans
    /// </exception>
    public static void Pack<TSourceType, TSourceQuaternion, TDestinationElement, TDestinationQuaternion>(
        ReadOnlySpan<TSourceQuaternion> source,
        Span<TDestinationQuaternion> destination,
        Func<TSourceType, TDestinationElement> elementConverter
    )
        where TSourceQuaternion : unmanaged, IQuaternion<TSourceQuaternion, TSourceType>
        where TDestinationQuaternion : unmanaged, IQuaternion<TDestinationQuaternion, TDestinationElement>
        where TSourceType : unmanaged
        where TDestinationElement : unmanaged
    {
        if (destination.Length < source.Length)
            throw new ArgumentException("Destination span is not long enough to hold the converted vectors");
        if (TSourceQuaternion.ComponentCount != TDestinationQuaternion.ComponentCount)
            throw new ArgumentException("Source and destination vector types have different element counts");

        var src = source.Cast<TSourceQuaternion, TSourceType>();
        var dst = destination.Cast<TDestinationQuaternion, TDestinationElement>();

        for (var i = 0; i < src.Length; i++)
            dst[i] = elementConverter(src[i]);
    }

    /// <summary>
    ///     Convert a source vector (cast as a span of elements) to a destination vector (created from a span of elements)
    ///     using a per-element delegate converter function
    ///     This slightly quirky signature is a workaround to avoid generics hell where you have to explicitly write each type
    /// </summary>
    /// <param name="source">Source vector</param>
    /// <param name="destination">Destination vector, created from a span of elements</param>
    /// <param name="elementConverter">Per-element conversion delegate</param>
    /// <typeparam name="TSourceType">Element type of input span</typeparam>
    /// <typeparam name="TDestinationType">Element type of output vector</typeparam>
    /// <typeparam name="TSourceQuaternion">Type of input vector</typeparam>
    /// <typeparam name="TDestinationQuaternion">Type of output vector</typeparam>
    public static void Pack<TSourceType, TSourceQuaternion, TDestinationType, TDestinationQuaternion>(
        in TSourceQuaternion source,
        out TDestinationQuaternion destination,
        Func<TSourceType, TDestinationType> elementConverter
    )
        where TSourceType : unmanaged
        where TDestinationType : unmanaged
        where TSourceQuaternion : unmanaged, IQuaternion<TSourceQuaternion, TSourceType>
        where TDestinationQuaternion : unmanaged, IQuaternion<TDestinationQuaternion, TDestinationType>
    {
        if (TDestinationQuaternion.ComponentCount < TSourceQuaternion.ComponentCount)
            throw new ArgumentException("Destination vector type has fewer elements than source vector type");

        var src = source.AsSpan();
        Span<TDestinationType> dst = stackalloc TDestinationType[TDestinationQuaternion.ComponentCount];

        for (var i = 0; i < src.Length; i++)
            dst[i] = elementConverter(src[i]);

        destination = TDestinationQuaternion.Create(dst);
    }
}
