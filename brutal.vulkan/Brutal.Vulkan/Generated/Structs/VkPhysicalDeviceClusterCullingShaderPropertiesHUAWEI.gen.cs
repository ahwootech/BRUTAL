namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI.html">VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI</see> - Structure describing cluster culling shader properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_cluster_culling_shader
    ///         typedef struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxWorkGroupCount[3];
    ///             uint32_t           maxWorkGroupSize[3];
    ///             uint32_t           maxOutputClusterCount;
    ///             VkDeviceSize       indirectBufferOffsetAlignment;
    ///         } VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceClusterCullingShaderPropertiesHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxWorkGroupCount</c>
        /// </summary>
        [FieldOffset(16)]
        public uint3 MaxWorkGroupCount;

        /// <summary>
        ///     <c>MaxWorkGroupSize</c>
        /// </summary>
        [FieldOffset(28)]
        public uint3 MaxWorkGroupSize;

        /// <summary>
        ///     <c>MaxOutputClusterCount</c> is the maximum number of output cluster a single cluster culling shader workgroup can emit.
        /// </summary>
        [FieldOffset(40)]
        public int MaxOutputClusterCount;

        /// <summary>
        ///     <c>IndirectBufferOffsetAlignment</c> indicates the alignment for cluster drawing command buffer stride. <c>vkCmdDrawClusterIndirectHUAWEI::offset</c> <i>must</i> be a multiple of this value.
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 IndirectBufferOffsetAlignment;
    }
}
