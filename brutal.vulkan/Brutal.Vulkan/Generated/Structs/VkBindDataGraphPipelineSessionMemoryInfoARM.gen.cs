namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindDataGraphPipelineSessionMemoryInfoARM.html">VkBindDataGraphPipelineSessionMemoryInfoARM</see> - Structure describing how to bind a data graph pipeline session to memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBindDataGraphPipelineSessionMemoryInfoARM
    ///     </para>
    ///     <para>
    ///         The <c>VkBindDataGraphPipelineSessionMemoryInfoARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         typedef struct VkBindDataGraphPipelineSessionMemoryInfoARM {
    ///             VkStructureType                           sType;
    ///             const void*                               pNext;
    ///             VkDataGraphPipelineSessionARM             session;
    ///             VkDataGraphPipelineSessionBindPointARM    bindPoint;
    ///             uint32_t                                  objectIndex;
    ///             VkDeviceMemory                            memory;
    ///             VkDeviceSize                              memoryOffset;
    ///         } VkBindDataGraphPipelineSessionMemoryInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkBindDataGraphPipelineSessionMemoryInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindDataGraphPipelineSessionMemoryInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Session</c> is the data graph pipeline session to be attached to memory.
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphPipelineSessionARM Session;

        /// <summary>
        ///     <c>BindPoint</c> is the data graph pipeline session bind point to which <c>memory</c> is to be attached.
        /// </summary>
        [FieldOffset(24)]
        public VkDataGraphPipelineSessionBindPointARM BindPoint;

        /// <summary>
        ///     <c>ObjectIndex</c> is the index of the object for <c>bindPoint</c> at which <c>memory</c> is to be attached.
        /// </summary>
        [FieldOffset(28)]
        public int ObjectIndex;

        /// <summary>
        ///     <c>Memory</c> is a <c>VkDeviceMemory</c> object describing the device memory to attach.
        /// </summary>
        [FieldOffset(32)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is the start offset of the resion of <c>memory</c> which is to be bound to the data graph pipeline session.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 MemoryOffset;
    }
}
