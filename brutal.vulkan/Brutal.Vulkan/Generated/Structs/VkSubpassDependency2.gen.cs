namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassDependency2.html">VkSubpassDependency2</see> - Structure specifying a subpass dependency
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSubpassDependency2
    ///         The <c>VkSubpassDependency2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSubpassDependency2 {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             uint32_t                srcSubpass;
    ///             uint32_t                dstSubpass;
    ///             VkPipelineStageFlags    srcStageMask;
    ///             VkPipelineStageFlags    dstStageMask;
    ///             VkAccessFlags           srcAccessMask;
    ///             VkAccessFlags           dstAccessMask;
    ///             VkDependencyFlags       dependencyFlags;
    ///             int32_t                 viewOffset;
    ///         } VkSubpassDependency2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkSubpassDependency2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SubpassDependency2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcSubpass</c> is the subpass index of the first subpass in the dependency, or <c>VK_SUBPASS_EXTERNAL</c>.
        /// </summary>
        [FieldOffset(16)]
        public int SrcSubpass;

        /// <summary>
        ///     <c>DstSubpass</c> is the subpass index of the second subpass in the dependency, or <c>VK_SUBPASS_EXTERNAL</c>.
        /// </summary>
        [FieldOffset(20)]
        public int DstSubpass;

        /// <summary>
        ///     <c>SrcStageMask</c> is a bitmask of <c>VkPipelineStageFlags</c> specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-pipeline-stages-masks">source stage mask^</see>. If set to <c>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</c>, it is equivalent to setting it to <c>VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkPipelineStageFlags SrcStageMask;

        /// <summary>
        ///     <c>DstStageMask</c> is a bitmask of <c>VkPipelineStageFlags</c> specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-pipeline-stages-masks">destination stage mask^</see> If set to <c>VK_PIPELINE_STAGE_ALL_COMMANDS_BIT</c>, it is equivalent to setting it to <c>VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkPipelineStageFlags DstStageMask;

        /// <summary>
        ///     <c>SrcAccessMask</c> is a bitmask of <c>VkAccessFlags</c> specifying a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-access-masks">source access mask^</see>.
        /// </summary>
        [FieldOffset(32)]
        public VkAccessFlags SrcAccessMask;

        /// <summary>
        ///     <c>DstAccessMask</c> is a bitmask of <c>VkAccessFlags</c> specifying a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-access-masks">destination access mask^</see>.
        /// </summary>
        [FieldOffset(36)]
        public VkAccessFlags DstAccessMask;

        /// <summary>
        ///     <c>DependencyFlags</c> is a bitmask of <c>VkDependencyFlags</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkDependencyFlags DependencyFlags;

        /// <summary>
        ///     <c>ViewOffset</c> controls which views in the source subpass the views in the destination subpass depend on.
        /// </summary>
        [FieldOffset(44)]
        public int ViewOffset;
    }
}
