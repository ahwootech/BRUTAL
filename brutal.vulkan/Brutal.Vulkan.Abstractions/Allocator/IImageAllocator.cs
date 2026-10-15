namespace Brutal.VulkanApi.Abstractions;

/// <summary>
/// Struct containing information about an image allocation
/// </summary>
public struct ImageAllocationInfo
{
    /// <summary>
    /// Image handle
    /// </summary>
    public VkImage Image;

    /// <summary>
    /// Size of image
    /// </summary>
    public VkExtent3D Extent;

    /// <summary>
    /// Format of image, for reference
    /// </summary>
    public VkFormat Format;

    /// <summary>
    /// Number of mip levels
    /// </summary>
    public int MipLevels;

    /// <summary>
    /// Number of array layers allocated
    /// </summary>
    public int ArrayLayers;

    /// <summary>
    /// Memory allocation info
    /// </summary>
    public AllocationInfo MemAllocationInfo;

    /// <summary>
    /// Allocator-specific handle
    /// </summary>
    public nint AllocHandle => MemAllocationInfo.AllocHandle;

    /// <summary>
    /// Allocator that sourced this image
    /// </summary>
    public IImageAllocator Allocator => (IImageAllocator)MemAllocationInfo.Allocator;
}

/// <summary>
/// Interface for an image allocator object capable of allocating and freeing images
/// </summary>
public interface IImageAllocator : IAllocator
{
    /// <summary>
    /// Allocate an image with the given creation and allocation info.
    /// </summary>
    /// <param name="name">Debug name of allocation</param>
    /// <param name="imageCreateInfo">Vulkan image creation info</param>
    /// <param name="allocateCreateInfo">Memory allocation info</param>
    /// <returns>Struct containing all relevant information about the allocation</returns>
    public ImageAllocationInfo AllocateImage(
        in string name,
        in VkImageCreateInfo imageCreateInfo,
        in AllocationInfo.CreateInfo allocateCreateInfo
    );

    /// <summary>
    /// Free an image allocation
    /// </summary>
    /// <param name="inAllocation">Struct containing all relevant information about the allocation</param>
    public void FreeAllocation(in ImageAllocationInfo inAllocation);
}
