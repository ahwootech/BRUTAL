namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBuffer.html">VkBuffer</see> - Opaque handle to a buffer object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Buffers represent linear arrays of data which are used for various purposes
    ///         by binding them to a graphics or compute pipeline via descriptor sets or
    ///         certain commands, or by directly specifying them as parameters to certain
    ///         commands.
    ///     </para>
    ///     <para>
    ///         Buffers are represented by <c>VkBuffer</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkBuffer)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkBuffer : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Buffer;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkBuffer(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkBuffer NullHandle = new();
    }
}
