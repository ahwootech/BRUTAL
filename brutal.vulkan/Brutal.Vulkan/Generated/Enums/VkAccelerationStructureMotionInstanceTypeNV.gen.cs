namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceTypeNV.html">VkAccelerationStructureMotionInstanceTypeNV</see> - Enum specifying a type of acceleration structure motion instance data for building into an acceleration structure geometry
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureMotionInstanceTypeNV
    ///     </para>
    ///     <para>
    ///         The <c>VkAccelerationStructureMotionInstanceTypeNV</c> enumeration is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef enum VkAccelerationStructureMotionInstanceTypeNV {
    ///             VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV = 0,
    ///             VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV = 1,
    ///             VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV = 2,
    ///         } VkAccelerationStructureMotionInstanceTypeNV;
    ///     </code>
    /// </remarks>
    public enum VkAccelerationStructureMotionInstanceTypeNV : int
    {
        /// <summary>
        ///     <c>StaticNV</c> specifies that the instance is a static instance with no instance motion.
        /// </summary>
        StaticNV = 0,

        /// <summary>
        ///     <c>MatrixMotionNV</c>  specifies that the instance is a motion instance with motion specified by interpolation between two matrices.
        /// </summary>
        MatrixMotionNV = 1,

        /// <summary>
        ///     <c>SrtMotionNV</c>  specifies that the instance is a motion instance with motion specified by interpolation in the SRT decomposition.
        /// </summary>
        SrtMotionNV = 2,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
