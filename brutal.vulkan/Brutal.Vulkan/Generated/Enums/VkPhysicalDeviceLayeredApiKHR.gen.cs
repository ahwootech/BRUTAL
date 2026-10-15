namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLayeredApiKHR.html">VkPhysicalDeviceLayeredApiKHR</see> - API implemented by the layered implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The list of possible API implementations of a layered implementation
    ///         underneath the Vulkan physical device, as returned in
    ///         <c>VkPhysicalDeviceLayeredApiPropertiesKHR::layeredAPI</c>, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance7
    ///         typedef enum VkPhysicalDeviceLayeredApiKHR {
    ///             VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR = 0,
    ///             VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR = 1,
    ///             VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR = 2,
    ///             VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR = 3,
    ///             VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR = 4,
    ///         } VkPhysicalDeviceLayeredApiKHR;
    ///     </code>
    /// </remarks>
    public enum VkPhysicalDeviceLayeredApiKHR : int
    {
        /// <summary>
        ///     <c>VulkanKHR</c> - the device implements the Vulkan API.
        /// </summary>
        VulkanKHR = 0,

        /// <summary>
        ///     <c>D3D12KHR</c> - the device implements the D3D12 API.
        /// </summary>
        D3D12KHR = 1,

        /// <summary>
        ///     <c>MetalKHR</c> - the device implements the Metal API.
        /// </summary>
        MetalKHR = 2,

        /// <summary>
        ///     <c>OpenglKHR</c> - the device implements the OpenGL API.
        /// </summary>
        OpenglKHR = 3,

        /// <summary>
        ///     <c>OpenglesKHR</c> - the device implements the OpenGL ES API.
        /// </summary>
        OpenglesKHR = 4,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
