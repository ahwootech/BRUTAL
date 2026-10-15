namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyAccelerationStructureToMemoryInfoKHR.html">VkCopyAccelerationStructureToMemoryInfoKHR</see> - Parameters for serializing an acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyAccelerationStructureToMemoryInfoKHR
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkCopyAccelerationStructureToMemoryInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkAccelerationStructureKHR            src;
    ///             VkDeviceOrHostAddressKHR              dst;
    ///             VkCopyAccelerationStructureModeKHR    mode;
    ///         } VkCopyAccelerationStructureToMemoryInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCopyAccelerationStructureToMemoryInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyAccelerationStructureToMemoryInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Src</c> is the source acceleration structure for the copy.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureKHR Src;

        /// <summary>
        ///     <c>Dst</c> is the device or host address of memory which is the target for the copy.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressKHR Dst;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkCopyAccelerationStructureModeKHR</c> value specifying additional operations to perform during the copy.
        /// </summary>
        [FieldOffset(32)]
        public VkCopyAccelerationStructureModeKHR Mode;
    }
}
