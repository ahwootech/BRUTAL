namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureInstanceKHR.html">VkAccelerationStructureInstanceKHR</see> - Structure specifying a single acceleration structure instance for building into an acceleration structure geometry
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAccelerationStructureInstanceKHR
    ///     </para>
    ///     <para>
    ///         <i>Acceleration structure instances</i> <i>can</i> be built into top-level acceleration
    ///         structures.
    ///         Each acceleration structure instance is a separate entry in the top-level
    ///         acceleration structure which includes all the geometry of a bottom-level
    ///         acceleration structure at a transformed location.
    ///         Multiple instances <i>can</i> point to the same bottom level acceleration
    ///         structure.
    ///     </para>
    ///     <para>
    ///         An acceleration structure instance is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAccelerationStructureInstanceKHR {
    ///             VkTransformMatrixKHR          transform;
    ///             uint32_t                      instanceCustomIndex:24;
    ///             uint32_t                      mask:8;
    ///             uint32_t                      instanceShaderBindingTableRecordOffset:24;
    ///             VkGeometryInstanceFlagsKHR    flags:8;
    ///             uint64_t                      accelerationStructureReference;
    ///         } VkAccelerationStructureInstanceKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct VkAccelerationStructureInstanceKHR()
    {
        /// <summary>
        ///     <c>Transform</c> is a <c>VkTransformMatrixKHR</c> structure describing a transformation to be applied to the acceleration structure.
        /// </summary>
        [FieldOffset(0)]
        public VkTransformMatrixKHR Transform;

        /// <summary>
        ///     <c>InstanceCustomIndex</c> is a 24-bit application-specified index value accessible to ray shaders in the <c>InstanceCustomIndexKHR</c> built-in.
        /// </summary>
        [FieldOffset(48)]
        private int _instanceCustomIndex;

        /// <summary>
        ///     <c>Mask</c> is an 8-bit visibility mask for the geometry. The instance may: only be hit if `Cull Mask &amp; instance.mask != 0`
        /// </summary>
        [FieldOffset(48)]
        private int _mask;

        /// <summary>
        ///     <c>InstanceShaderBindingTableRecordOffset</c> is a 24-bit offset used in calculating the hit shader binding table index.
        /// </summary>
        [FieldOffset(52)]
        private int _instanceShaderBindingTableRecordOffset;

        /// <summary>
        ///     <c>Flags</c> is an 8-bit mask of <c>VkGeometryInstanceFlagsKHR</c> values to apply to this instance.
        /// </summary>
        [FieldOffset(52)]
        private VkGeometryInstanceFlagsKHR _flags;

        /// <summary>
        ///     <c>AccelerationStructureReference</c> is :
        /// </summary>
        [FieldOffset(56)]
        public nint AccelerationStructureReference;
    }

    public partial struct VkAccelerationStructureInstanceKHR
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
