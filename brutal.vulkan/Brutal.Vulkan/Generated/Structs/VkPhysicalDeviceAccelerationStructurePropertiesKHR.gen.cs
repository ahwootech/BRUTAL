namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAccelerationStructurePropertiesKHR.html">VkPhysicalDeviceAccelerationStructurePropertiesKHR</see> - Properties of the physical device for acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceAccelerationStructurePropertiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkPhysicalDeviceAccelerationStructurePropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           maxGeometryCount;
    ///             uint64_t           maxInstanceCount;
    ///             uint64_t           maxPrimitiveCount;
    ///             uint32_t           maxPerStageDescriptorAccelerationStructures;
    ///             uint32_t           maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
    ///             uint32_t           maxDescriptorSetAccelerationStructures;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindAccelerationStructures;
    ///             uint32_t           minAccelerationStructureScratchOffsetAlignment;
    ///         } VkPhysicalDeviceAccelerationStructurePropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceAccelerationStructurePropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceAccelerationStructurePropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxGeometryCount</c>
        /// </summary>
        [FieldOffset(16)]
        public nint MaxGeometryCount;

        /// <summary>
        ///     <c>MaxInstanceCount</c>
        /// </summary>
        [FieldOffset(24)]
        public nint MaxInstanceCount;

        /// <summary>
        ///     <c>MaxPrimitiveCount</c>
        /// </summary>
        [FieldOffset(32)]
        public nint MaxPrimitiveCount;

        /// <summary>
        ///     <c>MaxPerStageDescriptorAccelerationStructures</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxPerStageDescriptorAccelerationStructures;

        /// <summary>
        ///     <c>MaxPerStageDescriptorUpdateAfterBindAccelerationStructures</c>
        /// </summary>
        [FieldOffset(44)]
        public int MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;

        /// <summary>
        ///     <c>MaxDescriptorSetAccelerationStructures</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxDescriptorSetAccelerationStructures;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindAccelerationStructures</c>
        /// </summary>
        [FieldOffset(52)]
        public int MaxDescriptorSetUpdateAfterBindAccelerationStructures;

        /// <summary>
        ///     <c>MinAccelerationStructureScratchOffsetAlignment</c>
        /// </summary>
        [FieldOffset(56)]
        public int MinAccelerationStructureScratchOffsetAlignment;
    }
}
