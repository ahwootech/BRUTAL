namespace Brutal.TextureApi;

/// <summary>
/// Interface representing a texture.
/// </summary>
public interface ITexture
{
    /// <summary>
    ///     The texel data for this texture
    /// </summary>
    public Span<byte> Data { get; }

    /// <summary>
    /// The data for one image of the texture.
    /// </summary>
    /// <remarks>You cannot have 3d cubemaps, therefore the third parameter
    /// is used for face or slice depending on the type of texture.</remarks>
    /// <param name="level">The mip level of data to get</param>
    /// <param name="layer">The array layer of data to get</param>
    /// <param name="faceOrSlice">The face (If a cube map) or slice (if a depth texture) of data to get.</param>
    /// <exception cref="TextureException">Thrown if data cannot be retrieved</exception>
    public Span<byte> ImageData(int level, int layer, int faceOrSlice);

    /// <summary>
    /// The extent of this texture (in texels). This is equal to the extent of the largest
    /// mip level of the texture
    /// </summary>
    public TexelCount3 Extent { get; }

    /// <summary>
    ///  The <see cref="TextureFormat" /> of this texture. <para />You can convert this to a Vulkan
    /// texture format with a call to ToVkFormat(). e.g.
    /// myITexture.Format.ToVkFormat();
    /// </summary>
    public TextureFormat Format { get; }

    /// <summary>
    ///     The number of array layers in this texture
    /// </summary>
    public int LayerCount { get; }

    /// <summary>
    ///     The number of levels (mipmaps) in this texture
    /// </summary>
    public int LevelCount { get; }

    /// <summary>
    /// The number of faces in this texture. This is typically 1 unless IsCubemap == true
    /// in which it could be up to 6
    /// </summary>
    public int FaceCount { get; }

    /// <summary>
    /// Whether this texture is defined as a cubemap
    /// </summary>
    public bool IsCubemap { get; }

    /// <summary>
    /// Returns whether this ITexture is an array texture.
    /// </summary>
    public bool IsArray { get; }

    /// <summary>
    /// Returns the number of dimensions of this ITexture.
    /// </summary>
    public int DimensionCount { get; } // 1, 2 or 3d

    /// <summary>
    /// Byte count from start of one row of the texture to the next
    /// </summary>
    /// <param name="level">Mip level to get the pitch for</param>
    /// <returns>The number of bytes from start of one row to start of the next row</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if level is less than 0 or greater than mip levels - 1</exception>
    public ByteSize RowPitch(int level);
}
