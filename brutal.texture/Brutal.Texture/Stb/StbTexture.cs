using System.Diagnostics;
using Brutal.Numerics;
using Brutal.Pointers.Extensions;

namespace Brutal.TextureApi.Stb;

public abstract partial class StbTexture : ITexture
{
    internal struct CreateInfo
    {
        internal required int2 Extent;
        internal required int Channels;
        internal required int BytesPerChannel;
    }

    #region ITexture
    public unsafe Span<byte> Data => new(GetDataPointer(), ElementCount.Of(_dataSize));
    public TexelCount3 Extent => new(NativeInfo.Extent.X, NativeInfo.Extent.Y, 1);
    public abstract TextureFormat Format { get; }
    public int LayerCount => 1;
    public int LevelCount => 1;
    public int FaceCount => 1;
    public bool IsCubemap => false;
    public bool IsArray => false;
    public int DimensionCount => 2;

    public ByteSize RowPitch(int level)
    {
        if (level < 0 || level >= LevelCount)
            throw new ArgumentOutOfRangeException(nameof(level), level, $"Level must be in range [0, {LevelCount})");
        return _rowPitch;
    }

    /// <summary>
    /// Returns the bytes that the image takes up.
    /// </summary>
    /// <param name="level">Must be 0</param>
    /// <param name="layer">Must be 0</param>
    /// <param name="face">Must be 0</param>
    /// <returns></returns>
    public unsafe Span<byte> ImageData(int level, int layer, int face)
    {
        if (level != 0 || layer != 0 || face != 0)
            throw new TextureException($"level, layer and face must all be 0 for STB textures");
        return new Span<byte>(Data.AsPointer(), Data.Length);
    }

    #endregion

    public int Channels => NativeInfo.Channels;

    public void Destroy()
    {
        FreeNativeResources();
    }

    internal readonly CreateInfo NativeInfo;
    protected abstract unsafe byte* GetDataPointer();
    private readonly ByteSize _dataSize;
    private readonly ByteSize _rowPitch;

    internal StbTexture(CreateInfo info)
    {
        Debug.Assert(FaceCount == 1 && LevelCount == 1 && LayerCount == 1);
        NativeInfo = info;
        _dataSize = ByteSize.Of(
            NativeInfo.Extent.X * NativeInfo.Extent.Y * NativeInfo.Channels * NativeInfo.BytesPerChannel
        );
        _rowPitch = ByteSize.Of(NativeInfo.Extent.X * NativeInfo.Channels * NativeInfo.BytesPerChannel);
    }

    protected abstract void FreeNativeResources();
}
