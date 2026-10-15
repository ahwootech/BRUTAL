namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineInputAssemblyStateCreateInfo.html">VkPipelineInputAssemblyStateCreateInfo</see> - Structure specifying parameters of a newly created pipeline input assembly state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Each draw is made up of zero or more vertices and zero or more instances,
    ///         which are processed by the device and result in the assembly of primitives.
    ///         Primitives are assembled according to the <c>pInputAssemblyState</c> member
    ///         of the <c>VkGraphicsPipelineCreateInfo</c> structure, which is of type
    ///         <c>VkPipelineInputAssemblyStateCreateInfo</c>:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineInputAssemblyStateCreateInfo {
    ///             VkStructureType                            sType;
    ///             const void*                                pNext;
    ///             VkPipelineInputAssemblyStateCreateFlags    flags;
    ///             VkPrimitiveTopology                        topology;
    ///             VkBool32                                   primitiveRestartEnable;
    ///         } VkPipelineInputAssemblyStateCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineInputAssemblyStateCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineInputAssemblyStateCreateFlags Flags;

        /// <summary>
        ///     <c>Topology</c> is a <c>VkPrimitiveTopology</c> defining the primitive topology, as described below.
        /// </summary>
        [FieldOffset(20)]
        public VkPrimitiveTopology Topology;

        /// <summary>
        ///     <c>PrimitiveRestartEnable</c> controls whether a special vertex index value is treated as restarting the assembly of primitives. This enable only applies to indexed draws (<c>vkCmdDrawIndexed</c>, and <c>vkCmdDrawIndexedIndirect</c>), and the special index value is either 0xFFFFFFFF when the <c>indexType</c> parameter of <c>vkCmdBindIndexBuffer</c> is equal to <c>VK_INDEX_TYPE_UINT32</c>; or 0xFFFF when <c>indexType</c> is equal to <c>VK_INDEX_TYPE_UINT16</c>. Primitive restart is not allowed for &quot;`list`&quot; topologies.
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 PrimitiveRestartEnable;
    }
}
