using Brutal.Memory;
using Brutal.Numerics;
using Brutal.Pointers.Extensions;

namespace Brutal.TextureApi.Abstractions;

/// <summary>
///     A generic implementation of ITexture which can be used to hold user-defined texture data.
/// </summary>
/// <remarks>
///     Allocates its own memory for texture data. Must call Destroy() or use.
///     Has only a single mip level.
///     Has no row padding.
/// </remarks>
public class GenericTexture : ITexture
{
    /// <summary>
    ///     Info required to create a GenericTexture
    /// </summary>
    public struct CreateInfo
    {
        public required TextureFormat Format;
        public required TexelCount3 Extent;
        public required int LayerCount;
        public required int LevelCount;
        public required int FaceCount;
        public required bool IsCubemap;
        public required bool IsArray;
        public required int DimensionCount;
    }

    /// <summary>
    /// Describes the starting offset and byte length of an image.
    /// Used when creating a GenericTexture from a CreateInfo and memory size.
    /// </summary>
    public struct CreateImageRange
    {
        public required ByteSize StartByteOffset;
        public required ByteSize ByteLength;
        public required ByteSize RowPitch;
    }

    /// <summary>
    ///     Create a new generic texture with the given properties and allocation size.
    /// </summary>
    /// <param name="info">Properties describing the texture</param>
    /// <param name="memAllocSize">The required allocation size for texture data, in bytes, no row padding</param>
    /// <param name="imageRanges">The set of CreateImageRange objects describing where and how big the mip levels are.
    /// MUST be supplied with a valid set of ranges if any of info.LevelCount, info.LayerCount or info.FaceCount is greater than 1.
    /// If all of those properties are 1 then you can omit this argument which will treat all memory allocated as the memory
    /// of the one and only mip level, layer and face</param>
    /// <exception cref="TextureException">Thrown if memAllocSize is not valid for the supplied <paramref name="info" /> and <paramref name="imageRanges" /></exception>
    /// <remarks>
    ///     Will zero-initialize the texture data memory.
    ///     It is assumed you will fill the texture data in a valid manner for the info specified.
    /// </remarks>
    public unsafe GenericTexture(
        CreateInfo info,
        ByteSize memAllocSize,
        ReadOnlySpan<CreateImageRange> imageRanges = new()
    )
    {
        if (info.LevelCount == 0 || info.LayerCount == 0 || info.FaceCount == 0)
            throw new TextureException("LevelCount, LayerCount and FaceCount must all be greater than 0");

        _data = Mem.AllocZeroed(memAllocSize).Cast<byte>();
        _dataSize = memAllocSize;
        _info = info;
        _imageMemory = BuildImageMemoryRanges(info, memAllocSize, imageRanges);
        _rowPitches = new ByteSize[info.LevelCount];

        var descriptor = info.Format.Descriptor();
        var minimumMemoryRequired = ByteSize.Zero;
        for (var level = 0; level < info.LevelCount; ++level)
        {
            // Extent in # blocks wide, high, deep this image should be based on its texel extents.
            var levelExtentInBlocks = new ImageExtent(info.Extent, level, descriptor.BlockExtent).Blocks;
            var levelMinimumMemoryRequired =
                (levelExtentInBlocks.X * levelExtentInBlocks.Y * levelExtentInBlocks.Z) * descriptor.BlockSizeInBytes;
            minimumMemoryRequired += levelMinimumMemoryRequired;

            _rowPitches[level] = GetLevelInfo(level, 0, 0).ByteRowPitch;
        }
        if (memAllocSize < minimumMemoryRequired)
            throw new TextureException(
                $"memAllocSize {memAllocSize} is too small for the given extent {info.Extent} and format {info.Format}. Minimum size is {minimumMemoryRequired}"
            );
    }

    private Dictionary<long, ImageMemory> BuildImageMemoryRanges(
        CreateInfo info,
        ByteSize memAllocSize,
        ReadOnlySpan<CreateImageRange> levelRanges
    )
    {
        if (info is { LevelCount: 1, LayerCount: 1, FaceCount: 1 } && levelRanges.IsEmpty)
        {
            if (memAllocSize.Bytes % ((nuint)info.Extent.X * (nuint)info.Extent.Y * (nuint)info.Extent.Z) != 0)
                throw new TextureException(
                    $"Memory byte size ({memAllocSize.Bytes} is not a multiple of (X * Y * Z extents)"
                );

            var key = Key(0, 0, 0);
            return new Dictionary<long, ImageMemory>
            {
                [key] = new(
                    key,
                    ByteSize.Zero,
                    memAllocSize,
                    ByteSize.Of(memAllocSize.Bytes / (nuint)info.Extent.Z / (nuint)info.Extent.Y)
                ),
            };
        }

        var expectedRangeCount = info.LevelCount * info.LayerCount * info.FaceCount;
        if (levelRanges.Length != expectedRangeCount)
            throw new TextureException(
                $"Wrong levelRanges length. Expected {expectedRangeCount}, received {levelRanges.Length}"
            );

        var imageMemory = new Dictionary<long, ImageMemory>(levelRanges.Length);
        var index = 0;
        for (var level = 0; level < info.LevelCount; ++level)
        for (var layer = 0; layer < info.LayerCount; ++layer)
        for (var face = 0; face < info.FaceCount; ++face)
        {
            var key = Key(level, layer, face);
            imageMemory[key] = new ImageMemory(
                key,
                levelRanges[index].StartByteOffset,
                levelRanges[index].ByteLength,
                levelRanges[index].RowPitch
            );
            ++index;
        }

        return imageMemory;
    }

    /// <summary>
    ///     Create a new generic texture, copying the properties and data of an existing ITexture instance
    /// </summary>
    /// <param name="texture">The texture to copy</param>
    public unsafe GenericTexture(ITexture texture)
    {
        var data = Mem.AllocAndCopy(texture.Data);
        _data = data.AsPointer();
        _dataSize = ByteSize.Of(data);

        _imageMemory = BuildImageMemoryRangesFromTextureMips(texture);

        _rowPitches = new ByteSize[texture.LevelCount];
        for (var level = 0; level < texture.LevelCount; ++level)
            _rowPitches[level] = texture.RowPitch(level);

        _info = new CreateInfo
        {
            Format = texture.Format,
            Extent = texture.Extent,
            LayerCount = texture.LayerCount,
            LevelCount = texture.LevelCount,
            FaceCount = texture.FaceCount,
            IsCubemap = texture.IsCubemap,
            IsArray = texture.IsArray,
            DimensionCount = texture.DimensionCount,
        };
    }

    private unsafe Dictionary<long, ImageMemory> BuildImageMemoryRangesFromTextureMips(ITexture texture)
    {
        var imageMemory = new Dictionary<long, ImageMemory>();

        for (var level = 0; level < texture.LevelCount; ++level)
        for (var layer = 0; layer < texture.LayerCount; ++layer)
        for (var face = 0; face < texture.FaceCount; ++face)
        {
            var data = texture.ImageData(level, layer, face);
            var imageDataOffset = ByteSize.Of(data.AsPointer() - texture.Data.AsPointer());
            var key = Key(level, layer, face);
            imageMemory[key] = new ImageMemory(key, imageDataOffset, ByteSize.Of(data), texture.RowPitch(level));
        }

        return imageMemory;
    }

    public static class Defaults
    {
        public static GenericTexture Uncompressed(
            TextureFormat format,
            int2 extent,
            int levels = 1,
            int layers = 1,
            int faces = 1
        )
        {
            var createInfo = MakeInfo(format, extent);
            createInfo.IsArray = layers > 1;
            createInfo.IsCubemap = faces == 6;

            var descriptor = format.Descriptor();
            if (descriptor.IsBlockCompressed)
                throw new ArgumentException($"Texture format is a block compressed format");

            var memAllocSize = ByteSize.Zero;
            var offset = ByteSize.Zero;
            var ranges = new CreateImageRange[levels];
            for (var level = 0; level < levels; ++level)
            {
                var bytesForLevel = (ByteSize)
                    Math.Max(
                        1,
                        (createInfo.Extent.X >> level)
                            * Math.Max(1, createInfo.Extent.Y >> level)
                            * descriptor.BlockSizeInBytes
                    );

                memAllocSize += bytesForLevel;
                ranges[level] = new()
                {
                    StartByteOffset = offset,
                    ByteLength = bytesForLevel,
                    RowPitch = bytesForLevel,
                };
                offset += bytesForLevel;
            }

            return new GenericTexture(createInfo, memAllocSize, ranges);
        }

        /// <summary>
        ///     Creates a generic 2D, single layer, single level texture with R8G8B8_UNorm format
        /// </summary>
        /// <remarks>There is no row padding.</remarks>
        /// <param name="extent">The required extent of the texture</param>
        /// <returns>A new GenericTexture</returns>
        public static GenericTexture RGB8UNorm(int2 extent)
        {
            var createInfo = MakeInfo(TextureFormat.R8G8B8_UNorm, extent);
            var memAllocSize =
                createInfo.Extent.X * createInfo.Extent.Y * createInfo.Format.Descriptor().BlockSizeInBytes;
            return new GenericTexture(createInfo, memAllocSize);
        }

        /// <summary>
        ///     Creates a generic 2D, single layer, single level texture with R8G8B8A8_UNorm format
        /// </summary>
        /// <remarks>There is no row padding.</remarks>
        /// <param name="extent">The required extent of the texture</param>
        /// <returns>A new GenericTexture</returns>
        public static GenericTexture RGBA8UNorm(int2 extent)
        {
            var createInfo = MakeInfo(TextureFormat.R8G8B8A8_UNorm, extent);
            var memAllocSize =
                createInfo.Extent.X * createInfo.Extent.Y * createInfo.Format.Descriptor().BlockSizeInBytes;
            return new GenericTexture(createInfo, memAllocSize);
        }

        private static CreateInfo MakeInfo(TextureFormat format, int2 extent)
        {
            return new CreateInfo
            {
                Format = format,
                Extent = new TexelCount3(extent.X, extent.Y, 1),
                LayerCount = 1,
                LevelCount = 1,
                FaceCount = 1,
                IsCubemap = false,
                IsArray = false,
                DimensionCount = 2,
            };
        }
    }

    public unsafe Span<byte> Data => new(_data, ElementCount.Of(_dataSize));

    public unsafe Span<byte> ImageData(int level, int layer, int face)
    {
        var levelInfo = GetLevelInfo(level, layer, face);
        return new Span<byte>(_data + levelInfo.StartByte, ElementCount.Of(levelInfo.ByteLength));
    }

    public TexelCount3 Extent => _info.Extent;
    public int Width => Extent.X;
    public int Height => Extent.Y;
    public int Depth => Extent.Z;

    public TextureFormat Format => _info.Format;
    public int LayerCount => _info.LayerCount;
    public int LevelCount => _info.LevelCount;
    public int FaceCount => _info.FaceCount;
    public bool IsCubemap => _info.IsCubemap;
    public bool IsArray => _info.IsArray;
    public int DimensionCount => _info.DimensionCount;

    public ByteSize RowPitch(int level)
    {
        if (level < 0 || level >= LevelCount)
            throw new ArgumentOutOfRangeException(nameof(level), level, $"Level must be in range [0, {LevelCount})");
        return _rowPitches[level];
    }

    public void Destroy()
    {
        FreeData();
    }

    private unsafe void FreeData()
    {
        Mem.Free(_data);
    }

    private struct ImageMemory
    {
        public ImageMemory(long key, ByteSize startByte, ByteSize byteLength, ByteSize byteRowPitch)
        {
            Key = key;
            StartByte = startByte;
            ByteLength = byteLength;
            ByteRowPitch = byteRowPitch;
        }

        public ByteSize ByteRowPitch { get; init; }
        public long Key { get; init; }
        public ByteSize StartByte { get; init; }
        public ByteSize ByteLength { get; init; }
    }

    private long Key(int level, int layer, int face)
    {
        return (_info.LayerCount * _info.FaceCount) * level + _info.FaceCount * layer + face;
    }

    private ImageMemory GetLevelInfo(int level, int layer, int face)
    {
        return _imageMemory[Key(level, layer, face)];
    }

    private readonly unsafe byte* _data;
    private readonly ByteSize _dataSize;
    private readonly CreateInfo _info;
    private readonly Dictionary<long, ImageMemory> _imageMemory;
    private readonly ByteSize[] _rowPitches;
}
