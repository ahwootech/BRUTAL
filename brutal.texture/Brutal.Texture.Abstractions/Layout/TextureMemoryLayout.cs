using System.Diagnostics;

namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Describes how a texture is laid out in memory. Provides the FormatDescriptor for a texture
/// as well as a TextureImageMemoryLayout object for each level of the texture.
/// </summary>
/// <remarks>
/// <para />Each level's data is calculated and cached on first use so multiple calls to query the same
/// mip level layout does not incur extra cost.<br/>
/// </remarks>
public class TextureMemoryLayout
{
    public TextureMemoryLayout(ITexture texture)
    {
        _texture = texture;
        _descriptor = texture.Format.Descriptor();

        _imageLayouts = new Lazy<TextureImageMemoryLayout>[texture.LevelCount];
        for (var mipLevelIndex = 0; mipLevelIndex < texture.LevelCount; mipLevelIndex++)
        {
            var mipLevel = mipLevelIndex;
            _imageLayouts[mipLevelIndex] = new Lazy<TextureImageMemoryLayout>(
                () => ImageLayoutForLevel(mipLevel),
                true
            );
        }
    }

    /// <summary>
    /// Returns the FormatDescriptor for the texture.
    /// </summary>
    public FormatDescriptor Descriptor => _descriptor;

    /// <summary>
    /// Returns the TextureImageMemoryLayout object for a single level of a texture.
    /// </summary>
    /// <param name="level">The mip level to retrieve the TextureImageMemoryLayout for.</param>
    /// <returns cref="TextureImageMemoryLayout">TextureImageMemoryLayout for the mip level</returns>
    /// <exception cref="ArgumentOutOfRangeException">throws ArgumentOutOfRangeException if level is not within the valid range of mip levels (0 based) for the texture</exception>
    public TextureImageMemoryLayout ImageLayout(int level)
    {
        Debug.Assert(_texture != null);
        Debug.Assert(_imageLayouts.Length == _texture.LevelCount);

        if (level < 0 || level >= _texture.LevelCount)
            throw new ArgumentOutOfRangeException(
                nameof(level),
                level,
                $"Level must be in range [0, {_texture.LevelCount})"
            );

        return _imageLayouts[level].Value;
    }

    private TextureImageMemoryLayout ImageLayoutForLevel(int level)
    {
        return new TextureImageMemoryLayout(
            new ImageExtent(_texture.Extent, level, _descriptor.BlockExtent),
            _texture.RowPitch(level),
            _descriptor.BlockSizeInBytes
        );
    }

    private readonly ITexture _texture;
    private readonly FormatDescriptor _descriptor;
    private readonly Lazy<TextureImageMemoryLayout>[] _imageLayouts;
}
