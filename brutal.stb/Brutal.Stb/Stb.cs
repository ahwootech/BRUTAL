using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Brutal.Strings;

// ReSharper disable MemberCanBePrivate.Global

namespace Brutal.StbApi;

public static partial class Stb
{
    /// <summary>
    ///     Load image from file using 8-bits-per-channel interface.
    /// </summary>
    /// <param name="fileName">Name of the file to load</param>
    /// <param name="desiredChannels">If non-zero, the number of image components requested in the result</param>
    /// <returns>Byte* which points to the pixel data, or nullptr on an allocation failure or if the image is corrupt or invalid.</returns>
    /// <remarks>
    /// The pixel data consists of *y scanlines of *x pixels,
    /// with each pixel consisting of N interleaved 8-bit components; the first
    /// pixel pointed to is top-left-most in the image. There is no padding between
    /// image scanlines or between pixels, regardless of format. The number of
    /// components N is 'desired_channels' if desired_channels is non-zero, or
    /// *channels_in_file otherwise. If desired_channels is non-zero,
    /// *channels_in_file has the number of components that _would_ have been
    /// output otherwise. E.g. if you set desired_channels to 4, you will always
    /// get RGBA output, but you can check *channels_in_file to see if it's trivially
    /// opaque because e.g. there were only 3 channels in the source image.
    /// </remarks>
    public static unsafe StbImage8 Load(string fileName, int desiredChannels = 0)
    {
        ValidateDesiredChannels(desiredChannels);

        var ptr = PInvoke.stbi_load(fileName, out var width, out var height, out var channelsInFile, desiredChannels);

        return new StbImage8(ptr, width, height, desiredChannels != 0 ? desiredChannels : channelsInFile);
    }

    /// <summary>
    ///     Load image from memory using 8-bits-per-channel interface.
    /// </summary>
    /// <seealso cref="Load">Load</seealso>
    public static unsafe StbImage8 LoadFromMemory(ReadOnlySpan<byte> buffer, int desiredChannels = 0)
    {
        ValidateDesiredChannels(desiredChannels);

        var ptr = PInvoke.stbi_load_from_memory(
            buffer,
            buffer.Length,
            out var width,
            out var height,
            out var channelsInFile,
            desiredChannels
        );

        return new StbImage8(ptr, width, height, desiredChannels != 0 ? desiredChannels : channelsInFile);
    }

    /// <summary>
    ///     Load image from file using 16-bits-per-channel interface.
    /// </summary>
    /// <seealso cref="Load">Load</seealso>
    public static unsafe StbImage16 Load16(string fileName, int desiredChannels = 0)
    {
        ValidateDesiredChannels(desiredChannels);

        var ptr = PInvoke.stbi_load_16(
            fileName,
            out var width,
            out var height,
            out var channelsInFile,
            desiredChannels
        );

        return new StbImage16(ptr, width, height, desiredChannels != 0 ? desiredChannels : channelsInFile);
    }

    /// <summary>
    ///     Load image from memory using 16-bits-per-channel interface.
    /// </summary>
    /// <seealso cref="Load">Load</seealso>
    public static unsafe StbImage16 Load16FromMemory(ReadOnlySpan<byte> buffer, int desiredChannels = 0)
    {
        ValidateDesiredChannels(desiredChannels);

        var ptr = PInvoke.stbi_load_16_from_memory(
            buffer,
            buffer.Length,
            out var width,
            out var height,
            out var channelsInFile,
            desiredChannels
        );

        return new StbImage16(ptr, width, height, desiredChannels != 0 ? desiredChannels : channelsInFile);
    }

    /// <summary>
    ///     Load image from file using float-per-channel interface.
    /// </summary>
    /// <seealso cref="Load">Load</seealso>
    public static unsafe StbImageF LoadF(string fileName, int desiredChannels = 0)
    {
        ValidateDesiredChannels(desiredChannels);

        var ptr = PInvoke.stbi_loadf(fileName, out var width, out var height, out var channelsInFile, desiredChannels);

        return new StbImageF(ptr, width, height, desiredChannels != 0 ? desiredChannels : channelsInFile);
    }

    /// <summary>
    ///     Load image from memory using float-per-channel interface.
    /// </summary>
    /// <seealso cref="Load">Load</seealso>
    public static unsafe StbImageF LoadFFromMemory(ReadOnlySpan<byte> buffer, int desiredChannels = 0)
    {
        ValidateDesiredChannels(desiredChannels);

        var ptr = PInvoke.stbi_loadf_from_memory(
            buffer,
            buffer.Length,
            out var width,
            out var height,
            out var channelsInFile,
            desiredChannels
        );

        return new StbImageF(ptr, width, height, desiredChannels != 0 ? desiredChannels : channelsInFile);
    }

    /// <summary>
    ///     Creates a png image and writes to file
    /// </summary>
    /// <param name="fileName">The name of the file to create</param>
    /// <param name="width">The image width</param>
    /// <param name="height">The image height</param>
    /// <param name="channels">The number of channels per pixel</param>
    /// <param name="data">The image data, a pointer to the first byte of the top-left-most pixel</param>
    /// <param name="rowStrideInBytes">The distance in bytes from the first byte of a row of pixels to the first byte of the next row of pixels</param>
    /// <returns>True on success</returns>
    /// <remarks>
    /// The image is a rectangle of pixels stored from left-to-right, top-to-bottom.
    /// Each pixel contains 'comp' channels of data stored interleaved with 8-bits
    /// per channel, in the following order: 1=Y, 2=YA, 3=RGB, 4=RGBA. (Y is
    /// monochrome color.) The rectangle is 'w' pixels wide and 'h' pixels tall.
    /// <para />
    /// PNG creates output files with the same number of components as the input.
    /// <para />
    /// PNG supports writing rectangles of data even when the bytes storing rows of
    /// data are not consecutive in memory (e.g. sub-rectangles of a larger image),
    /// by supplying the stride between the beginning of adjacent rows. The other
    /// formats do not. (Thus you cannot write a native-format BMP through the BMP
    /// writer, both because it is in BGR order and because it may have padding
    /// at the end of the line.)
    /// <para />
    /// PNG allows you to set the deflate compression level by setting the global
    /// variable 'stbi_write_png_compression_level' (it defaults to 8).
    /// </remarks>
    public static bool WritePng(
        string fileName,
        int width,
        int height,
        int channels,
        ReadOnlySpan<byte> data,
        int rowStrideInBytes = 0
    )
    {
        return PInvoke.stbi_write_png(
            fileName,
            width,
            height,
            channels,
            data,
            rowStrideInBytes != 0 ? rowStrideInBytes : width * channels
        );
    }

    public static bool WritePng(string fileName, StbImage8 image)
    {
        return WritePng(
            fileName,
            image.Width,
            image.Height,
            image.Channels,
            image.AsSpan(),
            image.Width * image.Channels
        );
    }

    /// <summary>
    ///     Creates a bmp image and writes to file
    /// </summary>
    /// <param name="fileName">The name of the file to create</param>
    /// <param name="width">The image width</param>
    /// <param name="height">The image height</param>
    /// <param name="channels">The number of channels per pixel</param>
    /// <param name="data">The image data, a pointer to the first byte of the top-left-most pixel</param>
    /// <returns>True on success</returns>
    /// <remarks>
    /// The image is a rectangle of pixels stored from left-to-right, top-to-bottom.
    /// Each pixel contains 'comp' channels of data stored interleaved with 8-bits
    /// per channel, in the following order: 1=Y, 2=YA, 3=RGB, 4=RGBA. (Y is
    /// monochrome color.) The rectangle is 'w' pixels wide and 'h' pixels tall.
    /// <para />
    /// The BMP format expands Y to RGB in the file format and does not output alpha.
    /// </remarks>
    public static bool WriteBmp(string fileName, int width, int height, int channels, ReadOnlySpan<byte> data)
    {
        return PInvoke.stbi_write_bmp(fileName, width, height, channels, data);
    }

    public static bool WriteBmp(string fileName, StbImage8 image)
    {
        return WriteBmp(fileName, image.Width, image.Height, image.Channels, image.AsSpan());
    }

    /// <summary>
    ///     Creates a tga image and writes to file
    /// </summary>
    /// <param name="fileName">The name of the file to create</param>
    /// <param name="width">The image width</param>
    /// <param name="height">The image height</param>
    /// <param name="channels">The number of channels per pixel</param>
    /// <param name="data">The image data, a pointer to the first byte of the top-left-most pixel</param>
    /// <returns>True on success</returns>
    /// <remarks>
    /// The image is a rectangle of pixels stored from left-to-right, top-to-bottom.
    /// Each pixel contains 'comp' channels of data stored interleaved with 8-bits
    /// per channel, in the following order: 1=Y, 2=YA, 3=RGB, 4=RGBA. (Y is
    /// monochrome color.) The rectangle is 'w' pixels wide and 'h' pixels tall.
    /// <para />
    /// TGA supports RLE or non-RLE compressed data. To use non-RLE-compressed
    /// data, set the global variable 'stbi_write_tga_with_rle' to 0.
    /// </remarks>
    public static bool WriteTga(string fileName, int width, int height, int channels, ReadOnlySpan<byte> data)
    {
        return PInvoke.stbi_write_tga(fileName, width, height, channels, data);
    }

    public static bool WriteTga(string fileName, StbImage8 image)
    {
        return WriteTga(fileName, image.Width, image.Height, image.Channels, image.AsSpan());
    }

    /// <summary>
    ///     Creates a hdr image and writes to file
    /// </summary>
    /// <param name="fileName">The name of the file to create</param>
    /// <param name="width">The image width</param>
    /// <param name="height">The image height</param>
    /// <param name="channels">The number of channels per pixel</param>
    /// <param name="data">The image data, a pointer to the first byte of the top-left-most pixel</param>
    /// <returns>True on success</returns>
    /// <remarks>
    /// The image is a rectangle of pixels stored from left-to-right, top-to-bottom.
    /// Each pixel contains 'comp' channels of data stored interleaved with one float
    /// per channel, in the following order: 1=Y, 2=YA, 3=RGB, 4=RGBA. (Y is
    /// monochrome color.) The rectangle is 'w' pixels wide and 'h' pixels tall.
    /// <para />
    /// HDR expects linear float data. Since the format is always 32-bit rgb(e)
    /// data, alpha (if provided) is discarded, and for monochrome data it is
    /// replicated across all three channels.
    /// </remarks>
    public static bool WriteHdr(string fileName, int width, int height, int channels, ReadOnlySpan<float> data)
    {
        return PInvoke.stbi_write_hdr(fileName, width, height, channels, data);
    }

    public static bool WriteHdr(string fileName, StbImageF image)
    {
        return WriteHdr(fileName, image.Width, image.Height, image.Channels, image.AsSpan());
    }

    /// <summary>
    ///     Creates a jpg image and writes to file
    /// </summary>
    /// <param name="fileName">The name of the file to create</param>
    /// <param name="width">The image width</param>
    /// <param name="height">The image height</param>
    /// <param name="channels">The number of channels per pixel</param>
    /// <param name="data">The image data, a pointer to the first byte of the top-left-most pixel</param>
    /// <param name="quality">The compression quality to use, 1 lowest to 100 highest.</param>
    /// <returns>True on success</returns>
    /// <remarks>
    /// The image is a rectangle of pixels stored from left-to-right, top-to-bottom.
    /// Each pixel contains 'comp' channels of data stored interleaved with one float
    /// per channel, in the following order: 1=Y, 2=YA, 3=RGB, 4=RGBA. (Y is
    /// monochrome color.) The rectangle is 'w' pixels wide and 'h' pixels tall.
    /// <para />
    /// JPEG does ignore alpha channels in input data; quality is between 1 and 100.
    /// Higher quality looks better but results in a bigger image.
    /// JPEG baseline (no JPEG progressive).
    /// </remarks>
    public static bool WriteJpg(
        string fileName,
        int width,
        int height,
        int channels,
        ReadOnlySpan<byte> data,
        int quality
    )
    {
        return PInvoke.stbi_write_jpg(fileName, width, height, channels, data, quality);
    }

    public static bool WriteJpg(string fileName, StbImage8 image, int quality)
    {
        return WriteJpg(fileName, image.Width, image.Height, image.Channels, image.AsSpan(), quality);
    }

    /// <summary>
    ///     Get a brief reason for the most recent failure
    /// </summary>
    /// <returns>
    ///     A string describing the failure reason, or an empty string when no image operation has failed
    /// </returns>
    public static unsafe bool TryGetFailureReason([NotNullWhen(true)] out string? failureReason)
    {
        var reason = PInvoke.stbi_failure_reason();
        failureReason = reason == null ? null : Utf8.GetString(reason);

        return !string.IsNullOrEmpty(failureReason);
    }

    /// <summary>
    ///     Checks whether the file at this path contains HDR data
    /// </summary>
    /// <remarks>
    ///     Specifically checks whether this file has a Radiance RGBE header (which would typically be a .hdr file)
    /// </remarks>
    /// <param name="fileName">The path of the file to check</param>
    /// <returns>True if the file is HDR</returns>
    public static bool IsHdr(string fileName)
    {
        return PInvoke.stbi_is_hdr(fileName);
    }

    /// <summary>
    ///     Checks whether the data in this buffer contains HDR image data
    /// </summary>
    /// <remarks>
    ///     Specifically checks whether this data has a Radiance RGBE header (which would typically be a .hdr file)
    /// </remarks>
    /// <param name="buffer">The data to check</param>
    /// <returns>True if the data is HDR</returns>
    public static bool IsHdrFromMemory(ReadOnlySpan<byte> buffer)
    {
        return PInvoke.stbi_is_hdr_from_memory(buffer, buffer.Length);
    }

    /// <summary>
    ///     Checks whether the file at this path contains 16-bit-per-channel data
    /// </summary>
    /// <param name="fileName">The path of the file to check</param>
    /// <returns>True if the file is 16 bit</returns>
    public static bool Is16Bit(string fileName)
    {
        return PInvoke.stbi_is_16_bit(fileName);
    }

    /// <summary>
    ///     Checks whether the data in this buffer contains 16-bit-per-channel image data
    /// </summary>
    /// <param name="buffer">The data to check</param>
    /// <returns>True if the data is 16 bit</returns>
    public static bool Is16BitFromMemory(ReadOnlySpan<byte> buffer)
    {
        return PInvoke.stbi_is_16_bit_from_memory(buffer, buffer.Length);
    }

    private static void ValidateDesiredChannels(int desiredChannels)
    {
        // stb interprets 0 as "keep the source channel count" and 1-4 as grey, grey+alpha, RGB, RGBA.
        ArgumentOutOfRangeException.ThrowIfNegative(desiredChannels);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(desiredChannels, 4);
    }

    internal static partial class PInvoke
    {
        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial byte* stbi_load(
            string fileName,
            out int width,
            out int height,
            out int channelsInFile,
            int desiredChannels
        );

        [LibraryImport("stb")]
        public static unsafe partial byte* stbi_load_from_memory(
            ReadOnlySpan<byte> buffer,
            int len,
            out int width,
            out int height,
            out int channelsInFile,
            int desiredChannels
        );

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial ushort* stbi_load_16(
            string fileName,
            out int width,
            out int height,
            out int channelsInFile,
            int desiredChannels
        );

        [LibraryImport("stb")]
        public static unsafe partial ushort* stbi_load_16_from_memory(
            ReadOnlySpan<byte> buffer,
            int len,
            out int width,
            out int height,
            out int channelsInFile,
            int desiredChannels
        );

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial float* stbi_loadf(
            string fileName,
            out int width,
            out int height,
            out int channelsInFile,
            int desiredChannels
        );

        [LibraryImport("stb")]
        public static unsafe partial float* stbi_loadf_from_memory(
            ReadOnlySpan<byte> buffer,
            int len,
            out int width,
            out int height,
            out int channelsInFile,
            int desiredChannels
        );

        [LibraryImport("stb")]
        public static unsafe partial void stbi_image_free(void* data);

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool32 stbi_write_png(
            string fileName,
            int width,
            int height,
            int comp,
            ReadOnlySpan<byte> data,
            int strideInBytes
        );

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool32 stbi_write_bmp(
            string fileName,
            int width,
            int height,
            int comp,
            ReadOnlySpan<byte> data
        );

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool32 stbi_write_tga(
            string fileName,
            int width,
            int height,
            int comp,
            ReadOnlySpan<byte> data
        );

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool32 stbi_write_hdr(
            string fileName,
            int width,
            int height,
            int comp,
            ReadOnlySpan<float> data
        );

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool32 stbi_write_jpg(
            string fileName,
            int width,
            int height,
            int comp,
            ReadOnlySpan<byte> data,
            int quality
        );

        [LibraryImport("stb")]
        public static unsafe partial byte* stbi_failure_reason();

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool32 stbi_is_16_bit(string fileName);

        [LibraryImport("stb")]
        public static unsafe partial Bool32 stbi_is_16_bit_from_memory(ReadOnlySpan<byte> buffer, int len);

        [LibraryImport("stb", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool32 stbi_is_hdr(string fileName);

        [LibraryImport("stb")]
        public static unsafe partial Bool32 stbi_is_hdr_from_memory(ReadOnlySpan<byte> buffer, int len);
    }
}
