namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureVersionInfoKHR.html">VkAccelerationStructureVersionInfoKHR</see> - Acceleration structure version information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureVersionKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureVersionInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureVersionInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             const uint8_t*     pVersionData;
    ///         } VkAccelerationStructureVersionInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkAccelerationStructureVersionInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureVersionInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VersionData</c> is a pointer to the version header of an acceleration structure as defined in <c>vkCmdCopyAccelerationStructureToMemoryKHR</c>
        /// </summary>
        [FieldOffset(16)]
        public byte* VersionData;
    }
}
