namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFramebuffer.html">VkFramebuffer</see> - Opaque handle to a framebuffer object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Render passes operate in conjunction with <i>framebuffers</i>.
    ///         Framebuffers represent a collection of specific memory attachments that a
    ///         render pass instance uses.
    ///     </para>
    ///     <para>
    ///         Framebuffers are represented by <c>VkFramebuffer</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkFramebuffer)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkFramebuffer : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Framebuffer;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkFramebuffer(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkFramebuffer NullHandle = new();
    }
}
