namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPass.html">VkRenderPass</see> - Opaque handle to a render pass object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A render pass object represents a collection of attachments, subpasses, and
    ///         dependencies between the subpasses, and describes how the attachments are
    ///         used over the course of the subpasses.
    ///     </para>
    ///     <para>
    ///         Render passes are represented by <c>VkRenderPass</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkRenderPass)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkRenderPass : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.RenderPass;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkRenderPass(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkRenderPass NullHandle = new();
    }
}
