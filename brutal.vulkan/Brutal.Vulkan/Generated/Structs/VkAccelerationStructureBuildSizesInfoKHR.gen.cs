namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildSizesInfoKHR.html">VkAccelerationStructureBuildSizesInfoKHR</see> - Structure specifying build sizes for an acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureBuildSizesInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureBuildSizesInfoKHR</c> structure describes the
    ///         required build sizes for an acceleration structure and scratch buffers and
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureBuildSizesInfoKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       accelerationStructureSize;
    ///             VkDeviceSize       updateScratchSize;
    ///             VkDeviceSize       buildScratchSize;
    ///         } VkAccelerationStructureBuildSizesInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkAccelerationStructureBuildSizesInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureBuildSizesInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AccelerationStructureSize</c> is the size in bytes required in a <c>VkAccelerationStructureKHR</c> for a build or update operation.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 AccelerationStructureSize;

        /// <summary>
        ///     <c>UpdateScratchSize</c> is the size in bytes required in a scratch buffer for an update operation.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 UpdateScratchSize;

        /// <summary>
        ///     <c>BuildScratchSize</c> is the size in bytes required in a scratch buffer for a build operation.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 BuildScratchSize;
    }
}
