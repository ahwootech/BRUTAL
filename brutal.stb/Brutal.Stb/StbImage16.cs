using Brutal.Numerics;

namespace Brutal.StbApi;

public readonly unsafe struct StbImage16(ushort* inData, int inWidth, int inHeight, int inChannels)
    : INullable,
        IDisposable
{
    public readonly ushort* Data = inData;
    public readonly int Width = inWidth;
    public readonly int Height = inHeight;
    public readonly int Channels = inChannels;

    public Span<ushort> AsSpan()
    {
        return new Span<ushort>(Data, Width * Height * Channels);
    }

    public Span<T> AsSpan<T>()
        where T : IVector<T, ushort>
    {
        if (T.ComponentCount != Channels)
            throw new InvalidOperationException(
                $"Cannot convert to Span<{typeof(T).Name}> because it has {T.ComponentCount} components, but the image has {Channels} channels."
            );

        return new Span<T>(Data, Width * Height);
    }

    public void Dispose()
    {
        Stb.PInvoke.stbi_image_free(Data);
    }

    public bool IsNull()
    {
        return Data == null;
    }
}
