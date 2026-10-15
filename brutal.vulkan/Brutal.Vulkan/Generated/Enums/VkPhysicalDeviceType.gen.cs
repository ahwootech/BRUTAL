namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceType.html">VkPhysicalDeviceType</see> - Supported physical device types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The physical device types which may: be returned in
    ///         <c>VkPhysicalDeviceProperties::deviceType</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPhysicalDeviceType {
    ///             VK_PHYSICAL_DEVICE_TYPE_OTHER = 0,
    ///             VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = 1,
    ///             VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = 2,
    ///             VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = 3,
    ///             VK_PHYSICAL_DEVICE_TYPE_CPU = 4,
    ///         } VkPhysicalDeviceType;
    ///     </code>
    /// </remarks>
    public enum VkPhysicalDeviceType : int
    {
        /// <summary>
        ///     <c>Other</c> - the device does not match any other available types.
        /// </summary>
        Other = 0,

        /// <summary>
        ///     <c>IntegratedGpu</c> - the device is typically one embedded in or tightly coupled with the host.
        /// </summary>
        IntegratedGpu = 1,

        /// <summary>
        ///     <c>DiscreteGpu</c> - the device is typically a separate processor connected to the host via an interlink.
        /// </summary>
        DiscreteGpu = 2,

        /// <summary>
        ///     <c>VirtualGpu</c> - the device is typically a virtual node in a virtualization environment.
        /// </summary>
        VirtualGpu = 3,

        /// <summary>
        ///     <c>Cpu</c> - the device is typically running on the same processors as the host.  The physical device type is advertised for informational purposes only, and does not directly affect the operation of the system. However, the device type may: correlate with other advertised properties or capabilities of the system, such as how many memory heaps there are.
        /// </summary>
        Cpu = 4,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
