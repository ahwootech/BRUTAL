using Brutal.GliApi;

namespace Brutal.TextureApi.Gli;

public class GliTexture(Brutal.GliApi.Gli.Texture nativeTexture) : ITexture
{
    public unsafe Span<byte> ImageData(int level, int layer, int faceOrSlice)
    {
        var sliceSize = _impl.ImageSize(level) / Extent.Z;

        if (_impl.Target == Brutal.GliApi.Gli.Target._3D)
            return new(_impl.ImageData(level, layer, 0) + sliceSize * faceOrSlice, (int)sliceSize);

        return new(_impl.ImageData(level, layer, faceOrSlice), (int)sliceSize);
    }

    public unsafe Span<byte> Data => new(_impl.Data, (int)_impl.Size);
    public TexelCount3 Extent => new(_impl.Extent.X, _impl.Extent.Y, _impl.Extent.Z);
    public TextureFormat Format => _impl.Format.ToTextureFormat();
    public int LayerCount => (int)_impl.Layers;
    public int LevelCount => (int)_impl.Levels;
    public int FaceCount => (int)_impl.Faces;
    public bool IsCubemap => _impl.Target.IsCube();
    public bool IsArray => _impl.Target.IsArray();
    public int DimensionCount => _impl.Target.DimensionCount();

    public ByteSize RowPitch(int level)
    {
        if (level < 0 || level >= LevelCount)
            throw new ArgumentOutOfRangeException(nameof(level), level, $"Level must be in range [0, {LevelCount})");
        return ByteSize.Of(_impl.ImageRowPitch(level));
    }

    public static implicit operator Brutal.GliApi.Gli.Texture(GliTexture texture) => texture._impl;

    private readonly GliApi.Gli.Texture _impl = nativeTexture;

    public void Destroy()
    {
        _impl.Dispose();
    }
}
