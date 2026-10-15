using System.Collections.Frozen;
using Brutal.Pointers.Extensions;

namespace Brutal.TextureApi.Stb;

public static partial class Loader
{
    public static StbTexture LoadFromFile(string filePath, LoadSettings? loadInfo = null)
    {
        // Load settings can try force data type, otherwise use file's native data type
        var dataType = GetForceDataType(loadInfo) ?? GetNativeDataType(filePath);

        // Load settings can try force channel count, otherwise use file's native channel count
        var channelCount = GetForceChannels(loadInfo) ?? 0;

        switch (dataType)
        {
            case StbApi.Stb.DataType._8Bit:
            {
                var handle = StbApi.Stb.Load(filePath, channelCount);
                if (handle.IsNotNull())
                {
                    return new StbTexture8(handle);
                }
                break;
            }
            case StbApi.Stb.DataType._16Bit:
            {
                var handle = StbApi.Stb.Load16(filePath, channelCount);
                if (handle.IsNotNull())
                {
                    return new StbTexture16(handle);
                }
                break;
            }
            case StbApi.Stb.DataType.Float:
            {
                var handle = StbApi.Stb.LoadF(filePath, channelCount);
                if (handle.IsNotNull())
                {
                    return new StbTextureF(handle);
                }
                break;
            }
        }

        throw new StbTextureReadException(
            $"Failed to load texture from filePath \"{filePath}\", failure reason: {(StbApi.Stb.TryGetFailureReason(out var reason) ? reason : "Unknown")}"
        );
    }

    public static unsafe StbTexture LoadFromMemory(ReadOnlySpan<byte> data, LoadSettings? loadInfo = null)
    {
        // Load settings can try force data type, otherwise use file's native data type
        var dataType = GetForceDataType(loadInfo) ?? GetNativeDataType(data);

        // Load settings can try force channel count, otherwise use file's native channel count
        var channelCount = GetForceChannels(loadInfo) ?? 0;

        switch (dataType)
        {
            case StbApi.Stb.DataType._8Bit:
            {
                var handle = StbApi.Stb.LoadFromMemory(data, channelCount);
                if (handle.IsNotNull())
                {
                    return new StbTexture8(handle);
                }
                break;
            }
            case StbApi.Stb.DataType._16Bit:
            {
                var handle = StbApi.Stb.Load16FromMemory(data, channelCount);
                if (handle.IsNotNull())
                {
                    return new StbTexture16(handle);
                }
                break;
            }
            case StbApi.Stb.DataType.Float:
            {
                var handle = StbApi.Stb.LoadFFromMemory(data, channelCount);
                if (handle.IsNotNull())
                {
                    return new StbTextureF(handle);
                }

                break;
            }
        }

        throw new StbTextureReadException(
            $"Failed to load texture from data at 0x{(nint)data.AsPointer()}, failure reason: {(StbApi.Stb.TryGetFailureReason(out var reason) ? reason : "Unknown")}"
        );
    }

    public class LoadSettings : TextureLoadSettings
    {
        /// <summary>
        ///     Force StbTextureFactory to load image data into a texture of the target data type
        /// </summary>
        /// <remarks>
        /// If set, the factory will perform conversion into the target type, using scaling between 8-16 bit
        /// and/or HDR&lt;=&gt;LDR conversion as required.
        /// <para/>
        /// For example, loading a .hdr file as DataType._16bit will firstly load
        /// float data from the source, then use LDR to HDR conversion into 8 bit, then upscale to 16 bit.
        /// <para/>
        /// If not set, StbTextureFactory load functions will default to loading textures using their 'native' data type.
        /// </remarks>
        public StbApi.Stb.DataType? ForceDataType;

        /// <summary>
        ///     Force StbTextureFactory to load image data into a texture with the target channel count.
        /// </summary>
        /// <remarks>
        /// If set, the factory will add or remove channels when loading the data.
        /// <para/>
        /// Any added color channels (1-3) will be zeroed, alpha channels (4) will be set to max value.
        /// </remarks>
        public int? ForceChannels;

        /// <summary>
        ///     A LoadSettings preset which will force StbTextureFactory to load textures into R8G8B8A8_UNorm format
        /// </summary>
        public static readonly LoadSettings ForceRgba8 = new()
        {
            ForceChannels = 4,
            ForceDataType = StbApi.Stb.DataType._8Bit,
        };
    }

    #region Private
    private static StbApi.Stb.DataType? GetForceDataType(LoadSettings? loadInfo)
    {
        var settings = loadInfo ?? new();
        return settings.ForceDataType;
    }

    private static int? GetForceChannels(LoadSettings? loadInfo)
    {
        var settings = loadInfo ?? new LoadSettings();
        return settings.ForceChannels;
    }

    private static StbApi.Stb.DataType GetNativeDataType(string filePath)
    {
        if (StbApi.Stb.Is16Bit(filePath))
            return StbApi.Stb.DataType._16Bit;

        if (StbApi.Stb.IsHdr(filePath))
            return StbApi.Stb.DataType.Float;

        return StbApi.Stb.DataType._8Bit;
    }

    private static StbApi.Stb.DataType GetNativeDataType(ReadOnlySpan<byte> data)
    {
        if (StbApi.Stb.Is16BitFromMemory(data))
            return StbApi.Stb.DataType._16Bit;

        if (StbApi.Stb.IsHdrFromMemory(data))
            return StbApi.Stb.DataType.Float;

        return StbApi.Stb.DataType._8Bit;
    }
    #endregion

    // The full set of formats stb_image can DECODE. This is a superset of what stb_image_write
    // can ENCODE (see Stb.Writer.SupportedExtensions) - formats like .gif/.psd/.pic/.ppm/.pgm
    // are load-only. stb selects its decoder from the file's content, not its extension, so this
    // set only governs which extensions TextureLoader dispatches to the Stb loader.
    public static FrozenSet<string> SupportedExtensions { get; } =
        FrozenSet.Create(
            StringComparer.OrdinalIgnoreCase,
            [".png", ".jpg", ".jpeg", ".tga", ".bmp", ".hdr", ".psd", ".gif", ".pic", ".ppm", ".pgm"]
        );
}
