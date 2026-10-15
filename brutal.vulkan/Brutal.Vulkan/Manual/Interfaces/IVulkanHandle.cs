namespace Brutal.VulkanApi;

/// <summary>
/// Interface for Vulkan handles.
/// </summary>
public interface IVulkanHandle : INullable
{
    /// <summary>
    /// Gets the Vulkan object type of the handle.
    /// </summary>
    public VkObjectType VkObjectType { get; }

    /// <summary>
    /// Gets the handle value.
    /// </summary>
    public nint VkHandle { get; }
}
