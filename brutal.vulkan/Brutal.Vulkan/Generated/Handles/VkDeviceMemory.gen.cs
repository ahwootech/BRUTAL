namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceMemory.html">VkDeviceMemory</see> - Opaque handle to a device memory object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A Vulkan device operates on data in device memory via memory objects that
    ///         are represented in the API by a <c>VkDeviceMemory</c> handle:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDeviceMemory)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDeviceMemory : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DeviceMemory;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDeviceMemory(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDeviceMemory NullHandle = new();
    }
}
