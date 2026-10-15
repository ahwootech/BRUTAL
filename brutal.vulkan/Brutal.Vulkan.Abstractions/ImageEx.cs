namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Lightweight handle to an image allocation
/// </summary>
public readonly struct ImageEx : IDisposable
{
    public ref struct CreateInfo
    {
        /// <summary>The name to apply to the image and allocation</summary>
        public required string Name;

        /// <inheritdoc cref="VkImageCreateInfo.Flags"/>
        public VkImageCreateFlags ImageFlags;

        /// <inheritdoc cref="VkImageCreateInfo.ImageType"/>
        public VkImageType ImageType;

        /// <inheritdoc cref="VkImageCreateInfo.Format"/>
        public VkFormat ImageFormat;

        /// <inheritdoc cref="VkImageCreateInfo.Extent"/>
        public VkExtent3D ImageExtent;

        /// <inheritdoc cref="VkImageCreateInfo.MipLevels"/>
        public int ImageMipLevels;

        /// <inheritdoc cref="VkImageCreateInfo.ArrayLayers"/>
        public int ImageArrayLayers;

        /// <inheritdoc cref="VkImageCreateInfo.Samples"/>
        public VkSampleCountFlags ImageSamples;

        /// <inheritdoc cref="VkImageCreateInfo.Tiling"/>
        public VkImageTiling ImageTiling;

        /// <inheritdoc cref="VkImageCreateInfo.Usage"/>
        public VkImageUsageFlags ImageUsage;

        /// <inheritdoc cref="VkImageCreateInfo.SharingMode"/>
        public VkSharingMode ImageSharingMode;

        /// <inheritdoc cref="VkImageCreateInfo.QueueFamilyIndices"/>
        public ReadOnlySpan<int> ImageQueueFamilyIndices;

        /// <inheritdoc cref="VkImageCreateInfo.InitialLayout"/>
        public VkImageLayout ImageInitialLayout;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.Preference"/>
        public MemoryPreference AllocPreference;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.RequiredProperties"/>
        public VkMemoryPropertyFlags AllocRequiredProperties;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.PreferredProperties"/>
        public VkMemoryPropertyFlags AllocPreferredProperties;

        /// <inheritdoc cref="AllocationInfo.CreateInfo.Priority"/>
        public float AllocPriority;

        /// <summary>
        /// Extract or populate this struct with an ImageCreateInfo
        /// </summary>
        public unsafe VkImageCreateInfo ImageCreateInfo
        {
            get =>
                new()
                {
                    ImageType = ImageType,
                    ArrayLayers = ImageArrayLayers,
                    Samples = ImageSamples,
                    MipLevels = ImageMipLevels,
                    Flags = ImageFlags,
                    InitialLayout = ImageInitialLayout,
                    Format = ImageFormat,
                    Extent = ImageExtent,
                    Tiling = ImageTiling,
                    Usage = ImageUsage,
                    SharingMode = ImageSharingMode,
                    QueueFamilyIndices = ImageQueueFamilyIndices.AsPointer(),
                    QueueFamilyIndexCount = ImageQueueFamilyIndices.Length,
                };
            set
            {
                ImageType = value.ImageType;
                ImageArrayLayers = value.ArrayLayers;
                ImageSamples = value.Samples;
                ImageMipLevels = value.MipLevels;
                ImageFlags = value.Flags;
                ImageType = value.ImageType;
                ImageFormat = value.Format;
                ImageExtent = value.Extent;
                ImageTiling = value.Tiling;
                ImageUsage = value.Usage;
                ImageSharingMode = value.SharingMode;
                ImageQueueFamilyIndices = new ReadOnlySpan<int>(value.QueueFamilyIndices, value.QueueFamilyIndexCount);
            }
        }

        /// <summary>
        /// Extract or populate this struct with an AllocationInfo.CreateInfo
        /// </summary>
        public AllocationInfo.CreateInfo AllocationInfo
        {
            get =>
                new()
                {
                    Preference = AllocPreference,
                    RequiredProperties = AllocRequiredProperties,
                    PreferredProperties = AllocPreferredProperties,
                    Priority = AllocPriority,
                };
            set
            {
                AllocPreference = value.Preference;
                AllocRequiredProperties = value.RequiredProperties;
                AllocPreferredProperties = value.PreferredProperties;
                AllocPriority = value.Priority;
            }
        }
    }

    private readonly IImageAllocator _allocator;

    /// <summary>
    /// Handles to allocated objects and metadata
    /// </summary>
    public readonly ImageAllocationInfo AllocationInfo;

    /// <summary>
    /// Image handle
    /// </summary>
    public VkImage VkImage => AllocationInfo.Image;

    /// <summary>
    /// Image memory
    /// </summary>
    public VkDeviceMemory VkDeviceMemory => AllocationInfo.MemAllocationInfo.Memory;

    /// <summary>
    /// Size of image
    /// </summary>
    public VkExtent3D Extent => AllocationInfo.Extent;

    /// <summary>
    /// Format of allocated image
    /// </summary>
    public VkFormat Format => AllocationInfo.Format;

    /// <summary>
    /// Number of mip levels allocated
    /// </summary>
    public int MipLevels => AllocationInfo.MipLevels;

    /// <summary>
    /// Number of array layers allocated
    /// </summary>
    public int ArrayLayers => AllocationInfo.ArrayLayers;

    /// <summary>
    /// Allocator-specific handle
    /// </summary>
    public nint UserHandle => AllocationInfo.AllocHandle;

    private readonly VkImageSubresourceRange _fullRange;

    /// <summary>
    /// Construct an ImageEx object
    /// </summary>
    /// <param name="allocator">Allocator for image memory</param>
    /// <param name="createInfo">Creation struct</param>
    internal unsafe ImageEx(IImageAllocator allocator, CreateInfo createInfo)
    {
        _allocator = allocator;
        AllocationInfo = allocator.AllocateImage(
            createInfo.Name,
            createInfo.ImageCreateInfo,
            createInfo.AllocationInfo
        );

        _fullRange = new VkImageSubresourceRange
        {
            AspectMask = VkImageAspectFlags.None,
            BaseMipLevel = 0,
            LevelCount = AllocationInfo.MipLevels,
            BaseArrayLayer = 0,
            LayerCount = AllocationInfo.ArrayLayers,
        };
    }

    /// <summary>
    /// Constructor for an image that has already been preallocated
    /// </summary>
    /// <param name="allocationInfo">Allocated image sourced from an IImageAllocator</param>
    public ImageEx(ImageAllocationInfo allocationInfo)
    {
        AllocationInfo = allocationInfo;
        _allocator = (IImageAllocator)allocationInfo.MemAllocationInfo.Allocator;
    }

    /// <summary>
    /// Convenience method to create an image view from the image
    /// </summary>
    /// <param name="imageViewType">Type of imageview needed</param>
    /// <param name="subresourceRange">Range imageview should encompass</param>
    /// <returns>VkImageView handle. It is up to user to dispose of this</returns>
    public ImageViewEx CreateImageView(
        VkImageViewType imageViewType,
        VkImageSubresourceRange subresourceRange,
        VkAllocator? allocator
    )
    {
        var device = _allocator.GetDevice();
        var handle = device.CreateImageView(
            new VkImageViewCreateInfo
            {
                Image = VkImage,
                ViewType = imageViewType,
                Format = Format,
                SubresourceRange = subresourceRange,
            },
            allocator
        );
        return new ImageViewEx(device, this, handle, imageViewType, subresourceRange, allocator);
    }

    public VkImageSubresourceRange GetFullRange(VkImageAspectFlags aspectMask) =>
        _fullRange with
        {
            AspectMask = aspectMask,
        };

    /// <inheritdoc/>
    public void Dispose()
    {
        _allocator.FreeAllocation(in AllocationInfo);
    }
}

public static class ImageExExtensions
{
    public static ImageEx CreateImage(this IImageAllocator allocator, ImageEx.CreateInfo createInfo)
    {
        return new ImageEx(allocator, createInfo);
    }
}
