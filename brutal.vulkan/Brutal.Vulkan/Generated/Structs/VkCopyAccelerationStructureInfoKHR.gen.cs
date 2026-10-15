namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyAccelerationStructureInfoKHR.html">VkCopyAccelerationStructureInfoKHR</see> - Parameters for copying an acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyAccelerationStructureInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyAccelerationStructureInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkCopyAccelerationStructureInfoKHR {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkAccelerationStructureKHR            src;
    ///             VkAccelerationStructureKHR            dst;
    ///             VkCopyAccelerationStructureModeKHR    mode;
    ///         } VkCopyAccelerationStructureInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCopyAccelerationStructureInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyAccelerationStructureInfoKHR;

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
        ///     <c>Dst</c> is the target acceleration structure for the copy.
        /// </summary>
        [FieldOffset(24)]
        public VkAccelerationStructureKHR Dst;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkCopyAccelerationStructureModeKHR</c> value specifying additional operations to perform during the copy.
        /// </summary>
        [FieldOffset(32)]
        public VkCopyAccelerationStructureModeKHR Mode;
    }
}
