namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildGeometryInfoKHR.html">VkAccelerationStructureBuildGeometryInfoKHR</see> - Structure specifying the geometry data used to build an acceleration structure
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureBuildGeometryInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureBuildGeometryInfoKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureBuildGeometryInfoKHR {
    ///             VkStructureType                                     sType;
    ///             const void*                                         pNext;
    ///             VkAccelerationStructureTypeKHR                      type;
    ///             VkBuildAccelerationStructureFlagsKHR                flags;
    ///             VkBuildAccelerationStructureModeKHR                 mode;
    ///             VkAccelerationStructureKHR                          srcAccelerationStructure;
    ///             VkAccelerationStructureKHR                          dstAccelerationStructure;
    ///             uint32_t                                            geometryCount;
    ///             const VkAccelerationStructureGeometryKHR*           pGeometries;
    ///             const VkAccelerationStructureGeometryKHR* const*    ppGeometries;
    ///             VkDeviceOrHostAddressKHR                            scratchData;
    ///         } VkAccelerationStructureBuildGeometryInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.AccelerationStructureBuildGeometryInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is a <c>VkAccelerationStructureTypeKHR</c> value specifying the type of acceleration structure being built.
        /// </summary>
        [FieldOffset(16)]
        public VkAccelerationStructureTypeKHR Type;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkBuildAccelerationStructureFlagsKHR</c> specifying additional parameters of the acceleration structure.
        /// </summary>
        [FieldOffset(20)]
        public VkBuildAccelerationStructureFlagsKHR Flags;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkBuildAccelerationStructureModeKHR</c> value specifying the type of operation to perform.
        /// </summary>
        [FieldOffset(24)]
        public VkBuildAccelerationStructureModeKHR Mode;

        /// <summary>
        ///     <c>SrcAccelerationStructure</c> is a pointer to an existing acceleration structure that is to be used to update the <c>dstAccelerationStructure</c> acceleration structure when <c>mode</c> is <c>VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkAccelerationStructureKHR SrcAccelerationStructure;

        /// <summary>
        ///     <c>DstAccelerationStructure</c> is a pointer to the target acceleration structure for the build.
        /// </summary>
        [FieldOffset(40)]
        public VkAccelerationStructureKHR DstAccelerationStructure;

        /// <summary>
        ///     <c>GeometryCount</c> specifies the number of geometries that will be built into <c>dstAccelerationStructure</c>.
        /// </summary>
        [FieldOffset(48)]
        public int GeometryCount;

        /// <summary>
        ///     <c>Geometries</c> is a pointer to an array of <c>VkAccelerationStructureGeometryKHR</c> structures.
        /// </summary>
        [FieldOffset(56)]
        public VkAccelerationStructureGeometryKHR* Geometries;

        /// <summary>
        ///     <c>ppGeometries</c> is a pointer to an array of pointers to <c>VkAccelerationStructureGeometryKHR</c> structures.
        /// </summary>
        [FieldOffset(64)]
        public VkAccelerationStructureGeometryKHR** ppGeometries;

        /// <summary>
        ///     <c>ScratchData</c> is the device or host address of memory that will be used as scratch memory for the build.
        /// </summary>
        [FieldOffset(72)]
        public VkDeviceOrHostAddressKHR ScratchData;
    }
}
