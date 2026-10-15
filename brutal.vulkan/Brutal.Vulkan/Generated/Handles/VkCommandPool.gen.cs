namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandPool.html">VkCommandPool</see> - Opaque handle to a command pool object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Command pools are opaque objects that command buffer memory is allocated
    ///         from, and which allow the implementation to amortize the cost of resource
    ///         creation across multiple command buffers.
    ///         Command pools are externally synchronized, meaning that a command pool <i>must</i>
    ///         not be used concurrently in multiple threads.
    ///         That includes use via recording commands on any command buffers allocated
    ///         from the pool, as well as operations that allocate, free, and reset command
    ///         buffers or the pool itself.
    ///     </para>
    ///     <para>
    ///         Command pools are represented by <c>VkCommandPool</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkCommandPool)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkCommandPool : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.CommandPool;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkCommandPool(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkCommandPool NullHandle = new();
    }
}
