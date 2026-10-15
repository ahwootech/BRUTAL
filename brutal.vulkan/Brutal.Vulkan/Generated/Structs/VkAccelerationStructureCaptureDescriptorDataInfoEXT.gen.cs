namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCaptureDescriptorDataInfoEXT.html">VkAccelerationStructureCaptureDescriptorDataInfoEXT</see> - Structure specifying an acceleration structure for descriptor capture
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about the acceleration structure to get descriptor buffer
    ///         capture data for is passed in a
    ///         <c>VkAccelerationStructureCaptureDescriptorDataInfoEXT</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_buffer with VK_KHR_acceleration_structure or VK_NV_ray_tracing
    ///         typedef struct VkAccelerationStructureCaptureDescriptorDataInfoEXT {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkAccelerationStructureKHR    accelerationStructure;
    ///             VkAccelerationStructureNV     accelerationStructureNV;
    ///         } VkAccelerationStructureCaptureDescriptorDataInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkAccelerationStructureCaptureDescriptorDataInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureCaptureDescriptorDataInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AccelerationStructure</c> is the <c>VkAccelerationStructureKHR</c> handle of the acceleration structure to get opaque capture data for.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureKHR AccelerationStructure;

        /// <summary>
        ///     <c>AccelerationStructureNV</c> is the <c>VkAccelerationStructureNV</c> handle of the acceleration structure to get opaque capture data for.
        /// </summary>
        [FieldOffset(24)]
        public VkAccelerationStructureNV AccelerationStructureNV;
    }
}
