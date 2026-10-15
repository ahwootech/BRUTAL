namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceDataNV.html">VkAccelerationStructureMotionInstanceDataNV</see> - Union specifying an acceleration structure motion instance data for building into an acceleration structure geometry
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureMotionInstanceDataNV
    ///     </para>
    ///     <para>
    ///         Acceleration structure motion instance is defined by the union:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef union VkAccelerationStructureMotionInstanceDataNV {
    ///             VkAccelerationStructureInstanceKHR               staticInstance;
    ///             VkAccelerationStructureMatrixMotionInstanceNV    matrixMotionInstance;
    ///             VkAccelerationStructureSRTMotionInstanceNV       srtMotionInstance;
    ///         } VkAccelerationStructureMotionInstanceDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public partial struct VkAccelerationStructureMotionInstanceDataNV()
    {
        /// <summary>
        ///     <c>StaticInstance</c> is a <c>VkAccelerationStructureInstanceKHR</c> structure containing data for a static instance.
        /// </summary>
        [FieldOffset(0)]
        public VkAccelerationStructureInstanceKHR StaticInstance;

        /// <summary>
        ///     <c>MatrixMotionInstance</c> is a <c>VkAccelerationStructureMatrixMotionInstanceNV</c> structure containing data for a matrix motion instance.
        /// </summary>
        [FieldOffset(0)]
        public VkAccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;

        /// <summary>
        ///     <c>SrtMotionInstance</c> is a <c>VkAccelerationStructureSRTMotionInstanceNV</c> structure containing data for an SRT motion instance.
        /// </summary>
        [FieldOffset(0)]
        public VkAccelerationStructureSRTMotionInstanceNV SrtMotionInstance;
    }
}
