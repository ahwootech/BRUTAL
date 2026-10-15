namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCreateInfoNV.html">VkAccelerationStructureCreateInfoNV</see> - Structure specifying the parameters of a newly created acceleration structure object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureCreateInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureCreateInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkAccelerationStructureCreateInfoNV {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkDeviceSize                     compactedSize;
    ///             VkAccelerationStructureInfoNV    info;
    ///         } VkAccelerationStructureCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkAccelerationStructureCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CompactedSize</c> is the size from the result of <c>vkCmdWriteAccelerationStructuresPropertiesNV</c> if this acceleration structure is going to be the target of a compacting copy.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 CompactedSize;

        /// <summary>
        ///     <c>Info</c> is the <c>VkAccelerationStructureInfoNV</c> structure specifying further parameters of the created acceleration structure.
        /// </summary>
        [FieldOffset(24)]
        public VkAccelerationStructureInfoNV Info;
    }
}
