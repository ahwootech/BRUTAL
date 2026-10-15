using System.Text;
using Brutal.KtxApi;
using Brutal.KtxApi.Abstractions;

namespace Brutal.TextureApi.Ktx;

/*
 * If facecount == 6 (IsCubemap == true) then width and height must be the same and depth must be 0
 * pixelHeight must not be 0 for block-compressed formats, including BasisLZ/ETC1S and UASTC.
 * pixelDepth must not be 0 for block formats that have block depth > 1
 * pixelDepth must be 0 for depth or stencil formats.
 *
 * layercount is number of array elements. If not an array then layercount must be 0.
 *
 * faceCount specifies the number of cubemap faces.
 * For cubemaps and cubemap arrays this must be 6. For non cubemaps this must be 1.
 * Cubemap faces are stored in the order: +X, -X, +Y, -Y, +Z, -Z in a left-handed coordinate system with
 * +Y up and, with the +Z face forward, +X on the on the right.
 * All faces must have the same orientation which must be rd (top-left origin) which is assumed in the absence of
 * Section 5.2, “KTXorientation” metadata. See Appendix A, Cubemap Orientation for details.
 * Applications wanting to store incomplete cubemaps should flatten faces into a 2D array and use the metadata described in
 * Section 5.1, “KTXcubemapIncomplete” to signal which faces are present.
 *
 *  Type        pixelWidth        pixelHeight        pixelDepth        layerCount       faceCount
 *  1D          > 0               0                  0                 0                1
 *  2D          > 0               > 0                0                 0                1
 *  3D          > 0               > 0                >0                0                1
 *  Cubemap     > 0               > 0                0                 0                6
 *  1D Array    > 0               0                  0                 >0               1
 *  2d Array    > 0               > 0                0                 >0               1
 *  3d Array    > 0               > 0                >0                >0               1
 *  Cubemap Arr > 0               > 0                0                 >0               6
 */

public class KtxTexture : ITexture
{
    /// <summary>
    /// Create a KtxTexture from an existing KtxTextureHandle.
    /// </summary>
    /// <remarks> The commonTextureHandle must not currently be supercompressed.</remarks>
    /// <param name="commonTextureHandle">A native handle to a KTX V1 or V2 texture</param>
    /// <exception cref="TextureException">Thrown if the texture referenced by commonTextureHandle is super compressed</exception>
    public KtxTexture(KtxTextureHandle commonTextureHandle)
    {
        _commonTextureHandle = commonTextureHandle;
        if (_commonTextureHandle.NeedsTranscoding())
            throw new TextureException("Texture is supercompressed.");
    }

    #region ITexture Implementation

    /// <inheritdoc cref="ITexture.Data"/>
    public unsafe Span<byte> Data
    {
        get
        {
            EnsureLoaded();
            return new Span<byte>(_commonTextureHandle.GetData(), (int)_commonTextureHandle.GetDataSize());
        }
    }

    /// <inheritdoc cref="ITexture.Extent"/>
    public TexelCount3 Extent =>
        new(
            (int)_commonTextureHandle.BaseWidth,
            (int)_commonTextureHandle.BaseHeight,
            (int)_commonTextureHandle.BaseDepth
        );

    /// <inheritdoc cref="ITexture.Format"/>
    public TextureFormat Format => (TextureFormat)_commonTextureHandle.GetVkFormat();

    /// <inheritdoc cref="ITexture.LayerCount"/>
    public int LayerCount => (int)_commonTextureHandle.NumLayers;

    /// <inheritdoc cref="ITexture.LevelCount"/>
    public int LevelCount => (int)_commonTextureHandle.NumLevels;

    /// <inheritdoc cref="ITexture.FaceCount"/>
    public int FaceCount => (int)_commonTextureHandle.NumFaces;

    /// <inheritdoc cref="ITexture.IsCubemap"/>
    public bool IsCubemap => _commonTextureHandle.IsCubemap;

    /// <inheritdoc cref="ITexture.IsArray"/>
    public bool IsArray => _commonTextureHandle.IsArray;

    /// <inheritdoc cref="ITexture.DimensionCount"/>
    public int DimensionCount => (int)_commonTextureHandle.NumDimensions;

    /// <inheritdoc cref="ITexture.RowPitch"/>
    public unsafe ByteSize RowPitch(int level)
    {
        if (level < 0 || level >= LevelCount)
            throw new ArgumentOutOfRangeException(nameof(level), level, $"Level must be in range [0, {LevelCount})");

        _rowPitch ??= new ByteSize[LevelCount];
        if (_rowPitch[level] != 0)
            return _rowPitch[level];

        if (_commonTextureHandle.ClassId == ClassId.Texture2C)
        {
            var formatSize = _commonTextureHandle.Protected->FormatSize;
            var blocksWide = Math.Max(1, (_commonTextureHandle.BaseWidth / formatSize.BlockWidth) >> level);
            _rowPitch[level] = ByteSize.Of(blocksWide * ((int)formatSize.BlockSizeInBits >> 3));
            return _rowPitch[level];
        }

        _rowPitch[level] = (ByteSize)_commonTextureHandle.GetRowPitch((uint)level);
        return _rowPitch[level];
    }

    /// <inheritdoc cref="ITexture.ImageData"/>
    public Span<byte> ImageData(int level, int layer, int face)
    {
        EnsureLoaded();

        var getResult = _commonTextureHandle.GetImageData((uint)level, (uint)layer, (uint)face, out var data);
        if (getResult != KtxErrorCode.Success)
            throw new TextureException(
                $"Cannot get image data for KtxTexture. level:{level} layer:{layer} face:{face} error:{getResult}"
            );
        return data;
    }

    #endregion

    /// <summary>
    /// Returns a native handle to the KtxTexture
    /// </summary>
    /// <value></value>
    public KtxTextureHandle UnderlyingKtxTextureHandle => _commonTextureHandle;

    /// <summary>
    /// Frees all resources held by the the KtxTexture. After calling Destroy() the
    /// KtxTexture object is unusable.
    /// </summary>
    public void Destroy()
    {
        if (_commonTextureHandle.IsNotNull())
        {
            _commonTextureHandle.Destroy();
            _commonTextureHandle = default;
        }
    }

    /// <summary>
    /// Saves a KtxTexture to a file on disk.
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public KtxErrorCode SaveToFile(string filePath)
    {
        EnsureLoaded();
        return _commonTextureHandle.WriteToNamedFile(Encoding.UTF8.GetBytes(filePath));
    }

    /// <summary>
    /// Returns whether the row pitch for the texture has been padded to 4 bytes.
    /// <remarks>
    /// This is a special requirement for V1 Ktx files. The spec required the alignment of rows of uncompresed textures to 4 bytes.
    /// This requirement was removed for V2 textures but we do need to know if packing is occurring for V1 if using OpenGl,
    /// so we can set GL_UNPACK_ALIGNMENT.
    /// If this function returns true, then set GL_UNPACK_ALIGNMENT to 4 before uploading the texture otherwise
    /// set it to 1.</remarks>
    /// </summary>
    /// <param name="level">What level to check for padding</param>
    /// <returns>True if row pitch was padded to 4 bytes, false if not.</returns>
    /// <exception cref="TextureException">Thrown if the image is supercompressed</exception>
    public bool IsRow4BytePadded(int level)
    {
        if (_commonTextureHandle.ClassId == ClassId.Texture2C)
            return false;

        // Catches compressed textures (All multiple of 4 in element size), and uncompressed with 4 byte elements
        if (_commonTextureHandle.GetElementSize() % 4 == 0)
            return false;

        return _commonTextureHandle.GetRowPitch((uint)level)
            != _commonTextureHandle.GetElementSize() * (_commonTextureHandle.BaseWidth >> level);
    }

    #region Private
    private unsafe void EnsureLoaded()
    {
        if (_commonTextureHandle.GetData() != null)
            return;
        var loadResult = _commonTextureHandle.LoadImageData(null);
        if (loadResult != KtxErrorCode.Success)
            throw new TextureException($"Cannot load image data for KtxTexture. KtxErrorCode:{loadResult}");
    }

    private KtxTextureHandle _commonTextureHandle;
    private ByteSize[]? _rowPitch;
    #endregion
}
