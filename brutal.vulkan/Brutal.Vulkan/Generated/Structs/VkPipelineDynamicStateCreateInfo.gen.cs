namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineDynamicStateCreateInfo.html">VkPipelineDynamicStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline dynamic state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPipelineDynamicStateCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineDynamicStateCreateInfo {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkPipelineDynamicStateCreateFlags    flags;
    ///             uint32_t                             dynamicStateCount;
    ///             const VkDynamicState*                pDynamicStates;
    ///         } VkPipelineDynamicStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineDynamicStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineDynamicStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineDynamicStateCreateFlags Flags;

        /// <summary>
        ///     <c>DynamicStateCount</c> is the number of elements in the <c>pDynamicStates</c> array.
        /// </summary>
        [FieldOffset(20)]
        public int DynamicStateCount;

        /// <summary>
        ///     <c>DynamicStates</c> is a pointer to an array of <c>VkDynamicState</c> values specifying which pieces of pipeline state will use the values from dynamic state commands rather than from pipeline state creation information.
        /// </summary>
        [FieldOffset(24)]
        public VkDynamicState* DynamicStates;
    }
}
