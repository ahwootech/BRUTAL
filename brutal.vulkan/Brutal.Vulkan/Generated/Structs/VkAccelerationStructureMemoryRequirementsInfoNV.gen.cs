namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMemoryRequirementsInfoNV.html">VkAccelerationStructureMemoryRequirementsInfoNV</see> - Structure specifying acceleration to query for memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureMemoryRequirementsInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureMemoryRequirementsInfoNV</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkAccelerationStructureMemoryRequirementsInfoNV {
    ///             VkStructureType                                    sType;
    ///             const void*                                        pNext;
    ///             VkAccelerationStructureMemoryRequirementsTypeNV    type;
    ///             VkAccelerationStructureNV                          accelerationStructure;
    ///         } VkAccelerationStructureMemoryRequirementsInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureMemoryRequirementsInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> selects the type of memory requirement being queried. <c>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV</c> returns the memory requirements for the object itself. <c>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV</c> returns the memory requirements for the scratch memory when doing a build. <c>VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV</c> returns the memory requirements for the scratch memory when doing an update.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureMemoryRequirementsTypeNV Type;

        /// <summary>
        ///     <c>AccelerationStructure</c> is the acceleration structure to be queried for memory requirements.
        /// </summary>
        [FieldOffset(24)]
        public VkAccelerationStructureNV AccelerationStructure;
    }
}
