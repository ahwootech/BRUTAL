namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInfoNV.html">VkAccelerationStructureMotionInfoNV</see> - Structure specifying the parameters of a newly created acceleration structure object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureMotionInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureMotionInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef struct VkAccelerationStructureMotionInfoNV {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             uint32_t                                    maxInstances;
    ///             VkAccelerationStructureMotionInfoFlagsNV    flags;
    ///         } VkAccelerationStructureMotionInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkAccelerationStructureMotionInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureMotionInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxInstances</c> is the maximum number of instances that may: be used in the motion top-level acceleration structure.
        /// </summary>
        [FieldOffset(16)]
        public int MaxInstances;

        /// <summary>
        ///     <c>Flags</c> is 0 and reserved for future use.
        /// </summary>
        [FieldOffset(20)]
        public VkAccelerationStructureMotionInfoFlagsNV Flags;
    }
}
