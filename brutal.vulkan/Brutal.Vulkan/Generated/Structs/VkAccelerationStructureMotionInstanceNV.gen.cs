namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceNV.html">VkAccelerationStructureMotionInstanceNV</see> - Structure specifying a single acceleration structure motion instance for building into an acceleration structure geometry
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureMotionInstanceNV
    ///     </para>
    ///     <para>
    ///         <i>Acceleration structure motion instances</i> <i>can</i> be built into top-level
    ///         acceleration structures.
    ///         Each acceleration structure instance is a separate entry in the top-level
    ///         acceleration structure which includes all the geometry of a bottom-level
    ///         acceleration structure at a transformed location including a type of motion
    ///         and parameters to determine the motion of the instance over time.
    ///     </para>
    ///     <para>
    ///         An acceleration structure motion instance is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef struct VkAccelerationStructureMotionInstanceNV {
    ///             VkAccelerationStructureMotionInstanceTypeNV     type;
    ///             VkAccelerationStructureMotionInstanceFlagsNV    flags;
    ///             VkAccelerationStructureMotionInstanceDataNV     data;
    ///         } VkAccelerationStructureMotionInstanceNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial struct VkAccelerationStructureMotionInstanceNV()
    {
        /// <summary>
        ///     <c>Type</c> is a <c>VkAccelerationStructureMotionInstanceTypeNV</c> enumerant identifying which type of motion instance this is and which type of the union is valid.
        /// </summary>
        [FieldOffset(0)]
        public VkAccelerationStructureMotionInstanceTypeNV Type;

        /// <summary>
        ///     <c>Flags</c> is currently unused, but is required to keep natural alignment of <c>data</c>.
        /// </summary>
        [FieldOffset(4)]
        public VkAccelerationStructureMotionInstanceFlagsNV Flags;

        /// <summary>
        ///     <c>Data</c> is a <c>VkAccelerationStructureMotionInstanceDataNV</c> containing motion instance data for this instance.
        /// </summary>
        [FieldOffset(8)]
        public VkAccelerationStructureMotionInstanceDataNV Data;
    }
}
