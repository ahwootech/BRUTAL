using System.Diagnostics;
using Brutal.Pointers.Extensions;
using Brutal.TextureApi.Abstractions;

namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Builds a set of information to describe how to stage an ITexture's data to a staging buffer
/// and upload it to a GPU.
/// </summary>
/// <remarks>
/// <list type="bullet">Removes row padding from KTX v1 textures.<br/></list>
/// <list type="bullet">Aligning data to lcm(4, texel block size)<br/></list>
/// <list type="bullet">Reducing number of copy commands where possible.<br/></list>
/// <list type="bullet">Currently does NOT squash all mips into one copy for staging even if it would be valid.<br/></list>
/// </remarks>
public class UploadRegions
{
    public enum Mode
    {
        BatchUploadRegions, // Try to put as many images into as few copy regions as possible
        UploadRegionPerImage, // Each image gets its own copy region
    }

    private UploadRegions()
    {
        _currentStageRegion = null;
        _currentUploadRegion = null;
    }

    /// <summary>
    /// Builds optimal staging and upload regions for entire mip range
    /// of a texture.
    /// </summary>
    /// <param name="texture"></param>
    /// <returns></returns>
    public static StageUploadRegions Build(ITexture texture)
    {
        var textureUpload = new UploadRegions();
        return textureUpload.BuildInternal(texture, 0, texture.LevelCount, Mode.BatchUploadRegions);
    }

    /// <summary>
    /// Builds optimal staging and upload regions for a selected mip range
    /// of a texture.
    /// </summary>
    /// <param name="texture">Texture to build regions for.</param>
    /// <param name="firstLevel">First level to build regions for. This level will become level 0 in the output.</param>
    /// <param name="maximumLevelCount">Maximum # of levels to build. Must be > 0.</param>
    /// <param name="mode">How to build the regions.</param>
    /// <returns>The <see cref="StageUploadRegions" /> that were built.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if firstLevel >= the level count of texture or maximumLevelCount &lt;= 0.</exception>
    public static StageUploadRegions Build(
        ITexture texture,
        int firstLevel,
        int maximumLevelCount,
        Mode mode = Mode.BatchUploadRegions
    )
    {
        if (firstLevel >= texture.LevelCount)
            throw new ArgumentOutOfRangeException(
                nameof(firstLevel),
                $"Level out of range. Expected 0-{texture.LevelCount - 1}, received {firstLevel}."
            );

        if (maximumLevelCount <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(maximumLevelCount),
                "Maximum level count must be greater than 0."
            );

        var textureUpload = new UploadRegions();
        return textureUpload.BuildInternal(texture, firstLevel, maximumLevelCount, mode);
    }

    /// <summary>
    /// Builds a datastructure describing how to upload an ITexture's images to a buffer and then to
    /// a GPU.
    /// Goes through the texture by level, layer, face and slice order, building the minimal
    /// set of copies required to upload the texture, removing any row padding and also
    /// aligning as needed.
    /// </summary>
    private unsafe StageUploadRegions BuildInternal(ITexture texture, int firstLevel, int levelCount, Mode mode)
    {
        var formatDescriptor = texture.Format.Descriptor();

        levelCount = Math.Min(levelCount, texture.LevelCount - firstLevel);

        _uploadRegions = new List<UploadRegion>(texture.LevelCount);
        _copyRegions = new List<StagingRegion>(texture.LevelCount * texture.LayerCount * texture.FaceCount);
        _lcm = CalculateLcm4AndTexelBlockSize(formatDescriptor.BlockSizeInBytes);
        _stageBufferDestinationOffset = ByteSize.Zero;

        var layouts = new TextureMemoryLayout(texture);
        var blockSizeBytes = formatDescriptor.BlockSizeInBytes;

        for (var level = firstLevel; level < firstLevel + levelCount; ++level)
        {
            // Output levels are re-based so the requested firstLevel becomes level 0. Batch-mode's
            // "start a new region when the level changes" check must compare against this re-based
            // level, otherwise any firstLevel > 0 never matches BaseLevel and every layer is split
            // into its own region.
            var outputLevel = level - firstLevel;
            var layout = layouts.ImageLayout(level);
            var rowWidthInBlocks = layout.Extent.Blocks.X;
            var rowPitch = layout.RowPitch;
            var depthSlices = texture.Is3d ? layout.Extent.Texels.Z : 1;

            for (var layer = 0; layer < texture.LayerCount; ++layer)
            {
                for (var face = 0; face < texture.FaceCount; ++face)
                {
                    var sourceImageData = texture.ImageData(level, layer, face);
                    var sourceImageOffset = ByteSize.Of(sourceImageData.AsPointer() - texture.Data.AsPointer());

                    if (
                        _currentUploadRegion == null
                        || mode == Mode.UploadRegionPerImage
                        || (mode == Mode.BatchUploadRegions && outputLevel != _currentUploadRegion.BaseLevel)
                    )
                        NewUploadRegion(outputLevel, layer * texture.FaceCount + face);

                    for (var depthSlice = 0; depthSlice < depthSlices; ++depthSlice)
                    {
                        AddImageData(
                            sourceImageOffset,
                            ByteSize.Of(sourceImageData),
                            rowWidthInBlocks,
                            blockSizeBytes,
                            rowPitch
                        );
                        sourceImageOffset += ByteSize.Of(sourceImageData);
                    }
                    ++_currentUploadRegion!.LayerCount;
                }
            }
        }

        var minimumRequiredBytes =
            _copyRegions.Count == 0
                ? ByteSize.Of(0)
                : _copyRegions[^1].DestinationOffset + _copyRegions[^1].SizeInBytes;

        return new StageUploadRegions()
        {
            StageBufferRegions = _copyRegions,
            CopyToImageRegions = _uploadRegions,
            RequiredBufferSizeBytes = minimumRequiredBytes,
        };
    }

    private void AddImageData(
        ByteSize sourceImageOffset,
        ByteSize length,
        int rowWidthInBlocks,
        ByteSize blockSizeBytes,
        ByteSize rowPitch
    )
    {
        UpdateStageRegion(sourceImageOffset, rowWidthInBlocks, blockSizeBytes, rowPitch);
        ExtendStageRegion(length);
    }

    private bool ContinuesCurrentStageRegionSource(ByteSize sourceImageOffset)
    {
        return sourceImageOffset == _currentStageRegion!.SourceStartOffset + _currentStageRegion.SizeInBytes;
    }

    private bool ContinuesCurrentStageRegionDestination(ByteSize destinationOffset)
    {
        return destinationOffset == _currentStageRegion!.DestinationOffset + _currentStageRegion.SizeInBytes;
    }

    private void ExtendStageRegion(ByteSize sizeInBytes)
    {
        Debug.Assert(_currentStageRegion != null);

        _currentStageRegion.SizeInBytes += sizeInBytes;
        _stageBufferDestinationOffset += sizeInBytes;
    }

    private static uint CalculateLcm4AndTexelBlockSize(ByteSize texelBlocksize)
    {
        if (texelBlocksize == 0)
            return 0;

        var num1 = ByteSize.Of(4u);
        var num2 = texelBlocksize;
        while (num1 != num2)
        {
            if (num1 > num2)
            {
                num1 -= num2;
            }
            else
            {
                num2 -= num1;
            }
        }

        return (uint)(4 * texelBlocksize / num1);
    }

    private void NewUploadRegion(int baseLevel, int baseLayer)
    {
        Debug.Assert(!_uploadRegions.Any(r => r.BaseLayer == baseLayer && r.BaseLevel == baseLevel));

        _stageBufferDestinationOffset = AlignOffsetToNextLcm(_stageBufferDestinationOffset);

        _currentUploadRegion = new UploadRegion()
        {
            BaseLevel = baseLevel,
            BaseLayer = baseLayer,
            LayerCount = 0,
            BufferOffset = _stageBufferDestinationOffset,
        };
        _uploadRegions.Add(_currentUploadRegion);
    }

    private void UpdateStageRegion(
        ByteSize startOffset,
        int rowWidthInBlocks,
        ByteSize blockSizeBytes,
        ByteSize rowPitch
    )
    {
        Debug.Assert(
            _stageBufferDestinationOffset == 0
                || _currentStageRegion == null
                || _stageBufferDestinationOffset
                    >= _currentStageRegion.DestinationOffset + _currentStageRegion.SizeInBytes
        );

        if (_currentStageRegion != null)
        {
            if (
                ContinuesCurrentStageRegionSource(startOffset)
                && ContinuesCurrentStageRegionDestination(_stageBufferDestinationOffset)
            )
                return;
        }

        _currentStageRegion = new StagingRegion
        {
            DestinationOffset = _stageBufferDestinationOffset,
            SourceStartOffset = startOffset,
            SizeInBytes = ByteSize.Zero,
            RowWidthInBlocks = rowWidthInBlocks,
            BlockSizeBytes = blockSizeBytes,
            RowPitch = rowPitch,
        };
        _copyRegions.Add(_currentStageRegion);
    }

    private ByteSize AlignOffsetToNextLcm(ByteSize offset)
    {
        return ByteSize.Of((offset.Bytes + _lcm - 1) / _lcm * _lcm);
    }

    private ByteSize _stageBufferDestinationOffset;
    private uint _lcm;
    private StagingRegion? _currentStageRegion;
    private UploadRegion? _currentUploadRegion;
    private List<StagingRegion> _copyRegions = [];
    private List<UploadRegion> _uploadRegions = [];
}
