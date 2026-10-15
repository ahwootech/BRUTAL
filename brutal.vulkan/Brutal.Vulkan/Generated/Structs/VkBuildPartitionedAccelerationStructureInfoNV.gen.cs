namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBuildPartitionedAccelerationStructureInfoNV.html">VkBuildPartitionedAccelerationStructureInfoNV</see> - Structure describing build parameters for a PTLAS
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBuildPartitionedAccelerationStructureInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkBuildPartitionedAccelerationStructureInfoNV</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_partitioned_acceleration_structure
    ///         typedef struct VkBuildPartitionedAccelerationStructureInfoNV {
    ///             VkStructureType                                       sType;
    ///             void*                                                 pNext;
    ///             VkPartitionedAccelerationStructureInstancesInputNV    input;
    ///             VkDeviceAddress                                       srcAccelerationStructureData;
    ///             VkDeviceAddress                                       dstAccelerationStructureData;
    ///             VkDeviceAddress                                       scratchData;
    ///             VkDeviceAddress                                       srcInfos;
    ///             VkDeviceAddress                                       srcInfosCount;
    ///         } VkBuildPartitionedAccelerationStructureInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkBuildPartitionedAccelerationStructureInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BuildPartitionedAccelerationStructureInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Input</c> is a <c>VkPartitionedAccelerationStructureInstancesInputNV</c> structure describing the instance and partition count information in the PTLAS.
        /// </summary>
        [FieldOffset(16)]
        public VkPartitionedAccelerationStructureInstancesInputNV Input;

        /// <summary>
        ///     <c>SrcAccelerationStructureData</c> is `NULL` or an address of a previously built PTLAS. If non-`NULL`, the PTLAS stored at this address is used as a basis to create new PTLAS.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceAddress SrcAccelerationStructureData;

        /// <summary>
        ///     <c>DstAccelerationStructureData</c> is the address to store the built PTLAS.
        /// </summary>
        [FieldOffset(64)]
        public VkDeviceAddress DstAccelerationStructureData;

        /// <summary>
        ///     <c>ScratchData</c> is the device address of scratch memory that will be used during PTLAS build.
        /// </summary>
        [FieldOffset(72)]
        public VkDeviceAddress ScratchData;

        /// <summary>
        ///     <c>SrcInfos</c> is the device address of an array of <c>VkBuildPartitionedAccelerationStructureIndirectCommandNV</c> structures describing the type of operation to perform.
        /// </summary>
        [FieldOffset(80)]
        public VkDeviceAddress SrcInfos;

        /// <summary>
        ///     <c>SrcInfosCount</c> is a device address containing the size of <c>srcInfos</c> array.
        /// </summary>
        [FieldOffset(88)]
        public VkDeviceAddress SrcInfosCount;
    }
}
