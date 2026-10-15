namespace Brutal.TextureApi;

/// <summary>
///     Transient data which can be used to save a texture to file without requiring an ITexture wrapper
/// </summary>
public ref struct TextureDescriptor
{
    /// <inheritdoc cref="ITexture.Data"/>
    public required ReadOnlySpan<byte> Data;

    /// <inheritdoc cref="ITexture.Format"/>
    public required TextureFormat Format;

    /// <inheritdoc cref="ITexture.Extent"/>
    public required TexelCount3 Extent;

    /// <inheritdoc cref="ITexture.LayerCount"/>
    public required int LayerCount;

    /// <inheritdoc cref="ITexture.LevelCount"/>
    public required int MipmapCount;

    /// <inheritdoc cref="ITexture.FaceCount"/>
    public required int FaceCount;

    /// <inheritdoc cref="ITexture.IsCubemap"/>
    public required bool IsCubemap;
}
