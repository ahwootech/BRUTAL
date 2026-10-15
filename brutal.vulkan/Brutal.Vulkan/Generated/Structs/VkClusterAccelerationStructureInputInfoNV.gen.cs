namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkClusterAccelerationStructureInputInfoNV.html">VkClusterAccelerationStructureInputInfoNV</see> - Structure describing a cluster acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkClusterAccelerationStructureInputInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkClusterAccelerationStructureInputInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_cluster_acceleration_structure
    ///         typedef struct VkClusterAccelerationStructureInputInfoNV {
    ///             VkStructureType                            sType;
    ///             void*                                      pNext;
    ///             uint32_t                                   maxAccelerationStructureCount;
    ///             VkBuildAccelerationStructureFlagsKHR       flags;
    ///             VkClusterAccelerationStructureOpTypeNV     opType;
    ///             VkClusterAccelerationStructureOpModeNV     opMode;
    ///             VkClusterAccelerationStructureOpInputNV    opInput;
    ///         } VkClusterAccelerationStructureInputInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkClusterAccelerationStructureInputInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ClusterAccelerationStructureInputInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxAccelerationStructureCount</c> is the maximum number of acceleration structures that will be provided to the multi indirect operation.
        /// </summary>
        [FieldOffset(16)]
        public int MaxAccelerationStructureCount;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkBuildAccelerationStructureFlagsKHR</c> specifying flags for the multi indirect operation.
        /// </summary>
        [FieldOffset(20)]
        public VkBuildAccelerationStructureFlagsKHR Flags;

        /// <summary>
        ///     <c>OpType</c> is a <c>VkClusterAccelerationStructureOpTypeNV</c> value specifying the type of operation to perform.
        /// </summary>
        [FieldOffset(24)]
        public VkClusterAccelerationStructureOpTypeNV OpType;

        /// <summary>
        ///     <c>OpMode</c> is a <c>VkClusterAccelerationStructureOpModeNV</c> value specifying the mode of operation.
        /// </summary>
        [FieldOffset(28)]
        public VkClusterAccelerationStructureOpModeNV OpMode;

        /// <summary>
        ///     <c>OpInput</c> is a <c>VkClusterAccelerationStructureOpInputNV</c> value specifying the descriptions of the operation.
        /// </summary>
        [FieldOffset(32)]
        public VkClusterAccelerationStructureOpInputNV OpInput;
    }
}
