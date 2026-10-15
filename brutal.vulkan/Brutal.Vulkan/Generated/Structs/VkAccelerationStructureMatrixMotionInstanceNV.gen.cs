namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMatrixMotionInstanceNV.html">VkAccelerationStructureMatrixMotionInstanceNV</see> - Structure specifying a single acceleration structure matrix motion instance for building into an acceleration structure geometry
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureMatrixMotionInstanceNV
    ///     </para>
    ///     <para>
    ///         An acceleration structure matrix motion instance is defined by the
    ///         structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef struct VkAccelerationStructureMatrixMotionInstanceNV {
    ///             VkTransformMatrixKHR          transformT0;
    ///             VkTransformMatrixKHR          transformT1;
    ///             uint32_t                      instanceCustomIndex:24;
    ///             uint32_t                      mask:8;
    ///             uint32_t                      instanceShaderBindingTableRecordOffset:24;
    ///             VkGeometryInstanceFlagsKHR    flags:8;
    ///             uint64_t                      accelerationStructureReference;
    ///         } VkAccelerationStructureMatrixMotionInstanceNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct VkAccelerationStructureMatrixMotionInstanceNV()
    {
        /// <summary>
        ///     <c>TransformT0</c> is a <c>VkTransformMatrixKHR</c> structure describing a transformation to be applied to the acceleration structure at time 0.
        /// </summary>
        [FieldOffset(0)]
        public VkTransformMatrixKHR TransformT0;

        /// <summary>
        ///     <c>TransformT1</c> is a <c>VkTransformMatrixKHR</c> structure describing a transformation to be applied to the acceleration structure at time 1.
        /// </summary>
        [FieldOffset(48)]
        public VkTransformMatrixKHR TransformT1;

        /// <summary>
        ///     <c>InstanceCustomIndex</c> is a 24-bit application-specified index value accessible to ray shaders in the <c>InstanceCustomIndexKHR</c> built-in.
        /// </summary>
        [FieldOffset(96)]
        private int _instanceCustomIndex;

        /// <summary>
        ///     <c>Mask</c> is an 8-bit visibility mask for the geometry. The instance may: only be hit if `Cull Mask &amp; instance.mask != 0`
        /// </summary>
        [FieldOffset(96)]
        private int _mask;

        /// <summary>
        ///     <c>InstanceShaderBindingTableRecordOffset</c> is a 24-bit offset used in calculating the hit shader binding table index.
        /// </summary>
        [FieldOffset(100)]
        private int _instanceShaderBindingTableRecordOffset;

        /// <summary>
        ///     <c>Flags</c> is an 8-bit mask of <c>VkGeometryInstanceFlagsKHR</c> values to apply to this instance.
        /// </summary>
        [FieldOffset(100)]
        private VkGeometryInstanceFlagsKHR _flags;

        /// <summary>
        ///     <c>AccelerationStructureReference</c> is either:
        /// </summary>
        [FieldOffset(104)]
        public nint AccelerationStructureReference;
    }

    public partial struct VkAccelerationStructureMatrixMotionInstanceNV
    {
        /// <inheritdoc cref="_instanceCustomIndex"/>
        public int InstanceCustomIndex
        {
            get => BitFields.ExtractRange(_instanceCustomIndex, start: 0, length: 24);
            set => BitFields.SetRange(ref _instanceCustomIndex, start: 0, length: 24, value);
        }

        /// <inheritdoc cref="_mask"/>
        public int Mask
        {
            get => BitFields.ExtractRange(_mask, start: 24, length: 8);
            set => BitFields.SetRange(ref _mask, start: 24, length: 8, value);
        }

        /// <inheritdoc cref="_instanceShaderBindingTableRecordOffset"/>
        public int InstanceShaderBindingTableRecordOffset
        {
            get => BitFields.ExtractRange(_instanceShaderBindingTableRecordOffset, start: 0, length: 24);
            set => BitFields.SetRange(ref _instanceShaderBindingTableRecordOffset, start: 0, length: 24, value);
        }

        /// <inheritdoc cref="_flags"/>
        public VkGeometryInstanceFlagsKHR Flags
        {
            get => BitFields.ExtractRange(_flags, start: 24, length: 8);
            set => BitFields.SetRange(ref _flags, start: 24, length: 8, value);
        }
    }
}
