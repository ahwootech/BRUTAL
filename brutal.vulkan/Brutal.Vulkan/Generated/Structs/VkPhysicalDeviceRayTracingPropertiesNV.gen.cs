namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPropertiesNV.html">VkPhysicalDeviceRayTracingPropertiesNV</see> - Properties of the physical device for ray tracing
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingPropertiesNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkPhysicalDeviceRayTracingPropertiesNV {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           shaderGroupHandleSize;
    ///             uint32_t           maxRecursionDepth;
    ///             uint32_t           maxShaderGroupStride;
    ///             uint32_t           shaderGroupBaseAlignment;
    ///             uint64_t           maxGeometryCount;
    ///             uint64_t           maxInstanceCount;
    ///             uint64_t           maxTriangleCount;
    ///             uint32_t           maxDescriptorSetAccelerationStructures;
    ///         } VkPhysicalDeviceRayTracingPropertiesNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingPropertiesNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderGroupHandleSize</c> is the size in bytes of the shader header.
        /// </summary>
        [FieldOffset(16)]
        public int ShaderGroupHandleSize;

        /// <summary>
        ///     <c>MaxRecursionDepth</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxRecursionDepth;

        /// <summary>
        ///     <c>MaxShaderGroupStride</c> is the maximum stride in bytes allowed between shader groups in the shader binding table.
        /// </summary>
        [FieldOffset(24)]
        public int MaxShaderGroupStride;

        /// <summary>
        ///     <c>ShaderGroupBaseAlignment</c> is the required: alignment in bytes for the base of the shader binding table.
        /// </summary>
        [FieldOffset(28)]
        public int ShaderGroupBaseAlignment;

        /// <summary>
        ///     <c>MaxGeometryCount</c> is the maximum number of geometries in the bottom level acceleration structure.
        /// </summary>
        [FieldOffset(32)]
        public nint MaxGeometryCount;

        /// <summary>
        ///     <c>MaxInstanceCount</c> is the maximum number of instances in the top level acceleration structure.
        /// </summary>
        [FieldOffset(40)]
        public nint MaxInstanceCount;

        /// <summary>
        ///     <c>MaxTriangleCount</c> is the maximum number of triangles in all geometries in the bottom level acceleration structure.
        /// </summary>
        [FieldOffset(48)]
        public nint MaxTriangleCount;

        /// <summary>
        ///     <c>MaxDescriptorSetAccelerationStructures</c> is the maximum number of acceleration structure descriptors that are allowed in a descriptor set.
        /// </summary>
        [FieldOffset(56)]
        public int MaxDescriptorSetAccelerationStructures;
    }
}
