namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineDepthStencilStateCreateInfo.html">VkPipelineDepthStencilStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline depth stencil state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineDepthStencilStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineDepthStencilStateCreateInfo {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkPipelineDepthStencilStateCreateFlags    flags;
    ///             VkBool32                                  depthTestEnable;
    ///             VkBool32                                  depthWriteEnable;
    ///             VkCompareOp                               depthCompareOp;
    ///             VkBool32                                  depthBoundsTestEnable;
    ///             VkBool32                                  stencilTestEnable;
    ///             VkStencilOpState                          front;
    ///             VkStencilOpState                          back;
    ///             float                                     minDepthBounds;
    ///             float                                     maxDepthBounds;
    ///         } VkPipelineDepthStencilStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineDepthStencilStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineDepthStencilStateCreateFlags Flags;

        /// <summary>
        ///     <c>DepthTestEnable</c> controls whether <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-depth">depth testing^</see> is enabled.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DepthTestEnable;

        /// <summary>
        ///     <c>DepthWriteEnable</c> controls whether <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-depth-write">depth writes^</see> are enabled when <c>depthTestEnable</c> is <c>VK_TRUE</c>. Depth writes are always disabled when <c>depthTestEnable</c> is <c>VK_FALSE</c>.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 DepthWriteEnable;

        /// <summary>
        ///     <c>DepthCompareOp</c> is a <c>VkCompareOp</c> value specifying the comparison operator to use in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-depth-comparison">Depth Comparison^</see> step of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-depth">depth test^</see>.
        /// </summary>
        [FieldOffset(28)]
        public VkCompareOp DepthCompareOp;

        /// <summary>
        ///     <c>DepthBoundsTestEnable</c> controls whether <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-dbt">depth bounds testing^</see> is enabled.
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 DepthBoundsTestEnable;

        /// <summary>
        ///     <c>StencilTestEnable</c> controls whether <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-stencil">stencil testing^</see> is enabled.
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 StencilTestEnable;

        /// <summary>
        ///     <c>Front</c> and <c>back</c> are <c>VkStencilOpState</c> values controlling the corresponding parameters of the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-stencil">stencil test^</see>.
        /// </summary>
        [FieldOffset(40)]
        public VkStencilOpState Front;

        /// <summary>
        ///     <c>Back</c>
        /// </summary>
        [FieldOffset(68)]
        public VkStencilOpState Back;

        /// <summary>
        ///     <c>MinDepthBounds</c> is the minimum depth bound used in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-dbt">depth bounds test^</see>.
        /// </summary>
        [FieldOffset(96)]
        public float MinDepthBounds;

        /// <summary>
        ///     <c>MaxDepthBounds</c> is the maximum depth bound used in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fragops-dbt">depth bounds test^</see>.
        /// </summary>
        [FieldOffset(100)]
        public float MaxDepthBounds;
    }
}
