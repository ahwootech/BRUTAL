namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueue.html">VkQueue</see> - Opaque handle to a queue object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Creating a logical device also creates the queues associated with that
    ///         device.
    ///         The queues to create are described by a set of <c>VkDeviceQueueCreateInfo</c>
    ///         structures that are passed to <c>vkCreateDevice</c> in
    ///         <c>pQueueCreateInfos</c>.
    ///         Queues cannot: be independently destroyed, and are instead destroyed with
    ///         the <c>VkDevice</c> that they were created from.
    ///     </para>
    ///     <para>
    ///         Queues are represented by <c>VkQueue</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_HANDLE(VkQueue)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkQueue : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Queue;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkQueue(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkQueue NullHandle = new();
    }
}
