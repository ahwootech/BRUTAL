namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPrivateDataSlot.html">VkPrivateDataSlot</see> - Opaque handle to a private data slot object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Private data slots are represented by <c>VkPrivateDataSlot</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkPrivateDataSlot)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkPrivateDataSlot : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.PrivateDataSlot;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkPrivateDataSlot(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkPrivateDataSlot NullHandle = new();
    }
}
