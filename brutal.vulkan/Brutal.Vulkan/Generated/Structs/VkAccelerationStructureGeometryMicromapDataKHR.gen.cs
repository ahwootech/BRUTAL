namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureGeometryMicromapDataKHR.html">VkAccelerationStructureGeometryMicromapDataKHR</see> - Structure specifying the data used to build a micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureGeometryMicromapDataKHR
    ///     </para>
    ///     <para>
    ///         When building micromaps with <c>vkCmdBuildAccelerationStructuresKHR</c>, a
    ///         <c>VkAccelerationStructureGeometryMicromapDataKHR</c> structure can be added
    ///         to the <c>pNext</c> chain of <c>VkAccelerationStructureGeometryKHR</c> to
    ///         specify the data used to build the micromap.
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureGeometryMicromapDataKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_opacity_micromap
    ///         typedef struct VkAccelerationStructureGeometryMicromapDataKHR {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             uint32_t                            usageCountsCount;
    ///             const VkMicromapUsageKHR*           pUsageCounts;
    ///             const VkMicromapUsageKHR* const*    ppUsageCounts;
    ///             VkDeviceAddress                     data;
    ///             VkDeviceAddress                     triangleArray;
    ///             VkDeviceSize                        triangleArrayStride;
    ///         } VkAccelerationStructureGeometryMicromapDataKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkAccelerationStructureGeometryMicromapDataKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureGeometryMicromapDataKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>UsageCountsCount</c> specifies the number of usage counts structures that will be used to determine the size of this micromap.
        /// </summary>
        [FieldOffset(16)]
        public int UsageCountsCount;

        /// <summary>
        ///     <c>UsageCounts</c> is a pointer to an array of <c>VkMicromapUsageKHR</c> structures.
        /// </summary>
        [FieldOffset(24)]
        public VkMicromapUsageKHR* UsageCounts;

        /// <summary>
        ///     <c>ppUsageCounts</c> is a pointer to an array of pointers to <c>VkMicromapUsageKHR</c> structures.
        /// </summary>
        [FieldOffset(32)]
        public VkMicromapUsageKHR** ppUsageCounts;

        /// <summary>
        ///     <c>Data</c> is the device address to memory which contains the data for the micromap.
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceAddress Data;

        /// <summary>
        ///     <c>TriangleArray</c> is the device address to memory containing the <c>VkMicromapTriangleKHR</c> data
        /// </summary>
        [FieldOffset(48)]
        public VkDeviceAddress TriangleArray;

        /// <summary>
        ///     <c>TriangleArrayStride</c> is the stride in bytes between each element of <c>triangleArray</c>
        /// </summary>
        [FieldOffset(56)]
        public ByteSize64 TriangleArrayStride;
    }
}
