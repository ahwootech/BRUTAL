namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassDependency.html">VkSubpassDependency</see> - Structure specifying a subpass dependency
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSubpassDependency
    ///         The <c>VkSubpassDependency</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSubpassDependency {
    ///             uint32_t                srcSubpass;
    ///             uint32_t                dstSubpass;
    ///             VkPipelineStageFlags    srcStageMask;
    ///             VkPipelineStageFlags    dstStageMask;
    ///             VkAccessFlags           srcAccessMask;
    ///             VkAccessFlags           dstAccessMask;
    ///             VkDependencyFlags       dependencyFlags;
    ///         } VkSubpassDependency;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct VkSubpassDependency()
    {
        /// <summary>
        ///     <c>SrcSubpass</c> is the subpass index of the first subpass in the dependency, or <c>VK_SUBPASS_EXTERNAL</c>.
        /// </summary>
        [FieldOffset(0)]
        public int SrcSubpass;

        /// <summary>
        ///     <c>DstSubpass</c> is the subpass index of the second subpass in the dependency, or <c>VK_SUBPASS_EXTERNAL</c>.
        /// </summary>
        [FieldOffset(4)]
        public int DstSubpass;

        /// <summary>
        ///     <c>SrcStageMask</c> is a bitmask of <c>VkPipelineStageFlags</c> specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-pipeline-stages-masks">source stage mask^</see>. If set to <c>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</c>, it is equivalent to setting it to <c>VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT</c>.
        /// </summary>
        [FieldOffset(8)]
        public VkPipelineStageFlags SrcStageMask;

        /// <summary>
        ///     <c>DstStageMask</c> is a bitmask of <c>VkPipelineStageFlags</c> specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-pipeline-stages-masks">destination stage mask^</see> If set to <c>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</c>, it is equivalent to setting it to <c>VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT</c>.
        /// </summary>
        [FieldOffset(12)]
        public VkPipelineStageFlags DstStageMask;

        /// <summary>
        ///     <c>SrcAccessMask</c> is a bitmask of <c>VkAccessFlags</c> specifying a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-access-masks">source access mask^</see>.
        /// </summary>
        [FieldOffset(16)]
        public VkAccessFlags SrcAccessMask;

        /// <summary>
        ///     <c>DstAccessMask</c> is a bitmask of <c>VkAccessFlags</c> specifying a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-access-masks">destination access mask^</see>.
        /// </summary>
        [FieldOffset(20)]
        public VkAccessFlags DstAccessMask;

        /// <summary>
        ///     <c>DependencyFlags</c> is a bitmask of <c>VkDependencyFlags</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkDependencyFlags DependencyFlags;
    }
}
