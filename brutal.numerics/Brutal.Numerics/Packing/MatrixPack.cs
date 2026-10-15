using CommunityToolkit.HighPerformance;

namespace Brutal.Numerics;

/// <summary>
///     Packing utilities for converting between matrix types
/// </summary>
public static class MatrixPack
{
    /// <summary>
    ///     Convert a span of matrices of one type to another using a per-element delegate converter function
    /// </summary>
    /// <param name="source">Source span of matrices</param>
    /// <param name="destination">Destination span of matrices</param>
    /// <param name="elementConverter">Delegate for converting between source and destination elements</param>
    /// <typeparam name="TSourceType">Source element type</typeparam>
    /// <typeparam name="TDestinationElement">Destination element type</typeparam>
    /// <typeparam name="TSourceMatrix">Source matrix type</typeparam>
    /// <typeparam name="TDestinationMatrix">Destination matrix type</typeparam>
    /// <exception cref="ArgumentException">
    ///     Source and destination matrix types have different element counts, or are different
    ///     length spans
    /// </exception>
    public static void Pack<TSourceType, TSourceMatrix, TDestinationElement, TDestinationMatrix>(
        ReadOnlySpan<TSourceMatrix> source,
        Span<TDestinationMatrix> destination,
        Func<TSourceType, TDestinationElement> elementConverter
    )
        where TSourceMatrix : unmanaged, IMatrix<TSourceMatrix, TSourceType>
        where TDestinationMatrix : unmanaged, IMatrix<TDestinationMatrix, TDestinationElement>
        where TSourceType : unmanaged
        where TDestinationElement : unmanaged
    {
        if (destination.Length < source.Length)
            throw new ArgumentException("Destination span is not long enough to hold the converted matrices");
        if (
            TSourceMatrix.RowCount != TDestinationMatrix.RowCount
            || TSourceMatrix.ColumnCount != TDestinationMatrix.ColumnCount
        )
            throw new ArgumentException("Source and destination matrix types have different element counts");

        var src = source.Cast<TSourceMatrix, TSourceType>();
        var dst = destination.Cast<TDestinationMatrix, TDestinationElement>();

        for (var i = 0; i < src.Length; i++)
            dst[i] = elementConverter(src[i]);
    }

    /// <summary>
    ///     Convert a source matrix (cast as a span of elements) to a destination matrix (created from a span of elements)
    ///     using a per-element delegate converter function
    ///     This slightly quirky signature is a workaround to avoid generics hell where you have to explicitly write each type
    /// </summary>
    /// <param name="source">Source matrix</param>
    /// <param name="destination">Destination matrix, created from a span of elements</param>
    /// <param name="elementConverter">Per-element conversion delegate</param>
    /// <typeparam name="TSourceType">Element type of input span</typeparam>
    /// <typeparam name="TDestinationType">Element type of output matrix</typeparam>
    /// <typeparam name="TSourceMatrix">Type of input matrix</typeparam>
    /// <typeparam name="TDestinationMatrix">Type of output matrix</typeparam>
    public static void Pack<TSourceType, TSourceMatrix, TDestinationType, TDestinationMatrix>(
        in TSourceMatrix source,
        out TDestinationMatrix destination,
        Func<TSourceType, TDestinationType> elementConverter
    )
        where TSourceType : unmanaged
        where TDestinationType : unmanaged
        where TSourceMatrix : unmanaged, IMatrix<TSourceMatrix, TSourceType>
        where TDestinationMatrix : unmanaged, IMatrix<TDestinationMatrix, TDestinationType>
    {
        if (
            TSourceMatrix.RowCount != TDestinationMatrix.RowCount
            || TSourceMatrix.ColumnCount != TDestinationMatrix.ColumnCount
        )
            throw new ArgumentException("Source and destination matrix types have different element counts");

        var src = source.AsSpan();
        Span<TDestinationType> dst =
            stackalloc TDestinationType[TDestinationMatrix.RowCount * TDestinationMatrix.ColumnCount];

        for (var i = 0; i < src.Length; i++)
            dst[i] = elementConverter(src[i]);

        destination = TDestinationMatrix.Create(dst);
    }
}
