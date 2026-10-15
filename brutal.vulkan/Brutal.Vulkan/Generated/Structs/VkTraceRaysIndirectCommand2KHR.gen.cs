namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTraceRaysIndirectCommand2KHR.html">VkTraceRaysIndirectCommand2KHR</see> - Structure specifying the parameters of an indirect trace ray command with indirect shader binding tables
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkTraceRaysIndirectCommand2KHR
    ///     </para>
    ///     <para>
    ///         The <c>VkTraceRaysIndirectCommand2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_maintenance1 with VK_KHR_ray_tracing_pipeline
    ///         typedef struct VkTraceRaysIndirectCommand2KHR {
    ///             VkDeviceAddress    raygenShaderRecordAddress;
    ///             VkDeviceSize       raygenShaderRecordSize;
    ///             VkDeviceAddress    missShaderBindingTableAddress;
    ///             VkDeviceSize       missShaderBindingTableSize;
    ///             VkDeviceSize       missShaderBindingTableStride;
    ///             VkDeviceAddress    hitShaderBindingTableAddress;
    ///             VkDeviceSize       hitShaderBindingTableSize;
    ///             VkDeviceSize       hitShaderBindingTableStride;
    ///             VkDeviceAddress    callableShaderBindingTableAddress;
    ///             VkDeviceSize       callableShaderBindingTableSize;
    ///             VkDeviceSize       callableShaderBindingTableStride;
    ///             uint32_t           width;
    ///             uint32_t           height;
    ///             uint32_t           depth;
    ///         } VkTraceRaysIndirectCommand2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct VkTraceRaysIndirectCommand2KHR()
    {
        /// <summary>
        ///     <c>RaygenShaderRecordAddress</c> is a basetype:VkDeviceAddress of the ray generation shader binding table record used by this command.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress RaygenShaderRecordAddress;

        /// <summary>
        ///     <c>RaygenShaderRecordSize</c> is a basetype:VkDeviceSize number of bytes corresponding to the ray generation shader binding table record at base address <c>raygenShaderRecordAddress</c>.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 RaygenShaderRecordSize;

        /// <summary>
        ///     <c>MissShaderBindingTableAddress</c> is a basetype:VkDeviceAddress of the first record in the miss shader binding table used by this command.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddress MissShaderBindingTableAddress;

        /// <summary>
        ///     <c>MissShaderBindingTableSize</c> is a basetype:VkDeviceSize number of bytes corresponding to the total size of the miss shader binding table at <c>missShaderBindingTableAddress</c> that may be accessed by this command.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MissShaderBindingTableSize;

        /// <summary>
        ///     <c>MissShaderBindingTableStride</c> is a basetype:VkDeviceSize number of bytes between records of the miss shader binding table.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MissShaderBindingTableStride;

        /// <summary>
        ///     <c>HitShaderBindingTableAddress</c> is a basetype:VkDeviceAddress of the first record in the hit shader binding table used by this command.
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceAddress HitShaderBindingTableAddress;

        /// <summary>
        ///     <c>HitShaderBindingTableSize</c> is a basetype:VkDeviceSize number of bytes corresponding to the total size of the hit shader binding table at <c>hitShaderBindingTableAddress</c> that may be accessed by this command.
        /// </summary>
        [FieldOffset(48)]
        public ByteSize64 HitShaderBindingTableSize;

        /// <summary>
        ///     <c>HitShaderBindingTableStride</c> is a basetype:VkDeviceSize number of bytes between records of the hit shader binding table.
        /// </summary>
        [FieldOffset(56)]
        public ByteSize64 HitShaderBindingTableStride;

        /// <summary>
        ///     <c>CallableShaderBindingTableAddress</c> is a basetype:VkDeviceAddress of the first record in the callable shader binding table used by this command.
        /// </summary>
        [FieldOffset(64)]
        public VkDeviceAddress CallableShaderBindingTableAddress;

        /// <summary>
        ///     <c>CallableShaderBindingTableSize</c> is a basetype:VkDeviceSize number of bytes corresponding to the total size of the callable shader binding table at <c>callableShaderBindingTableAddress</c> that may be accessed by this command.
        /// </summary>
        [FieldOffset(72)]
        public ByteSize64 CallableShaderBindingTableSize;

        /// <summary>
        ///     <c>CallableShaderBindingTableStride</c> is a basetype:VkDeviceSize number of bytes between records of the callable shader binding table.
        /// </summary>
        [FieldOffset(80)]
        public ByteSize64 CallableShaderBindingTableStride;

        /// <summary>
        ///     <c>Width</c> is the width of the ray trace query dimensions.
        /// </summary>
        [FieldOffset(88)]
        public int Width;

        /// <summary>
        ///     <c>Height</c> is height of the ray trace query dimensions.
        /// </summary>
        [FieldOffset(92)]
        public int Height;

        /// <summary>
        ///     <c>Depth</c> is depth of the ray trace query dimensions.
        /// </summary>
        [FieldOffset(96)]
        public int Depth;
    }
}
