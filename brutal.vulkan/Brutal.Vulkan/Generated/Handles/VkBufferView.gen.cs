namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferView.html">VkBufferView</see> - Opaque handle to a buffer view object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A <i>buffer view</i> represents a contiguous range of a buffer and a specific
    ///         format to be used to interpret the data.
    ///         Buffer views are used to enable shaders to access buffer contents using
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures">image operations^</see>.
    ///         In order to create a valid buffer view, the buffer <i>must</i> have been created
    ///         with at least one of the following usage flags:
    ///     </para>
    ///     <para>
    ///         * <c>VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT</c>
    ///         * <c>VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT</c>
    ///     </para>
    ///     <para>
    ///         Buffer views are represented by <c>VkBufferView</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkBufferView)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkBufferView : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.BufferView;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkBufferView(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkBufferView NullHandle = new();
    }
}
