namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBuffer.html">VkCommandBuffer</see> - Opaque handle to a command buffer object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Command buffers are objects used to record commands which <i>can</i> be
    ///         subsequently submitted to a device queue for execution.
    ///         There are two levels of command buffers - <i>primary command buffers</i>, which
    ///         <i>can</i> execute secondary command buffers, and which are submitted to queues,
    ///         and <i>secondary command buffers</i>, which <i>can</i> be executed by primary command
    ///         buffers, and which are not directly submitted to queues.
    ///     </para>
    ///     <para>
    ///         Command buffers are represented by <c>VkCommandBuffer</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_HANDLE(VkCommandBuffer)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkCommandBuffer : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.CommandBuffer;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkCommandBuffer(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkCommandBuffer NullHandle = new();
    }
}
