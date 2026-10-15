namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice.html">VkPhysicalDevice</see> - Opaque handle to a physical device object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Vulkan separates the concept of <i>physical</i> and <i>logical</i> devices.
    ///         A physical device usually represents a single complete implementation of
    ///         Vulkan (excluding instance-level functionality) available to the host, of
    ///         which there are a finite number.
    ///         A logical device represents an instance of that implementation with its own
    ///         state and resources independent of other logical devices.
    ///     </para>
    ///     <para>
    ///         Physical devices cannot: be independently destroyed, and are instead
    ///         destroyed with the <c>VkInstance</c> that they were retrieved from.
    ///     </para>
    ///     <para>
    ///         Physical devices are represented by <c>VkPhysicalDevice</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_HANDLE(VkPhysicalDevice)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkPhysicalDevice : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.PhysicalDevice;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkPhysicalDevice(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkPhysicalDevice NullHandle = new();
    }
}
