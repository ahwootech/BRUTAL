namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureInfoNV.html">VkAccelerationStructureInfoNV</see> - Structure specifying the parameters of acceleration structure object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing
    ///         typedef struct VkAccelerationStructureInfoNV {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             VkAccelerationStructureTypeNV           type;
    ///             VkBuildAccelerationStructureFlagsKHR    flags;
    ///             uint32_t                                instanceCount;
    ///             uint32_t                                geometryCount;
    ///             const VkGeometryNV*                     pGeometries;
    ///         } VkAccelerationStructureInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkAccelerationStructureInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is a <c>VkAccelerationStructureTypeNV</c> value specifying the type of acceleration structure that will be created.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureTypeNV Type;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkBuildAccelerationStructureFlagsNV</c> specifying additional parameters of the acceleration structure.
        /// </summary>
        [FieldOffset(20)]
        public VkBuildAccelerationStructureFlagsKHR Flags;

        /// <summary>
        ///     <c>InstanceCount</c> specifies the number of instances that will be in the new acceleration structure.
        /// </summary>
        [FieldOffset(24)]
        public int InstanceCount;

        /// <summary>
        ///     <c>GeometryCount</c> specifies the number of geometries that will be in the new acceleration structure.
        /// </summary>
        [FieldOffset(28)]
        public int GeometryCount;

        /// <summary>
        ///     <c>Geometries</c> is a pointer to an array of <c>geometryCount</c> <c>VkGeometryNV</c> structures containing the scene data being passed into the acceleration structure.
        /// </summary>
        [FieldOffset(32)]
        public VkGeometryNV* Geometries;
    }
}
