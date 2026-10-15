namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureMoveObjectsInputNV.html">VkClusterAccelerationStructureMoveObjectsInputNV</see> - Parameters describing move information for an acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureMoveObjectsInputNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureMoveObjectsInputNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureMoveObjectsInputNV {
    ///             VkStructureType                         sType;
    ///             void*                                   pNext;
    ///             VkClusterAccelerationStructureTypeNV    type;
    ///             VkBool32                                noMoveOverlap;
    ///             VkDeviceSize                            maxMovedBytes;
    ///         } VkClusterAccelerationStructureMoveObjectsInputNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkClusterAccelerationStructureMoveObjectsInputNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ClusterAccelerationStructureMoveObjectsInputNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is a <c>VkClusterAccelerationStructureTypeNV</c> value identifying the type of cluster acceleration structure.
        /// </summary>
        [FieldOffset(16)]
        public VkClusterAccelerationStructureTypeNV Type;

        /// <summary>
        ///     <c>NoMoveOverlap</c> specifies if the source and destination cluster acceleration structures overlap in memory for the move operation. If set to <c>VK_TRUE</c>, the source cluster acceleration structure remains valid after the move and move operation acts like a copy.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 NoMoveOverlap;

        /// <summary>
        ///     <c>MaxMovedBytes</c> is the maximum number of bytes that may: be moved in this operation.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MaxMovedBytes;
    }
}
