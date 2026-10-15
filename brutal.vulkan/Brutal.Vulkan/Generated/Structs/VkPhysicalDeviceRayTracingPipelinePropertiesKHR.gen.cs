namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRayTracingPipelinePropertiesKHR.html">VkPhysicalDeviceRayTracingPipelinePropertiesKHR</see> - Properties of the physical device for ray tracing
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRayTracingPipelinePropertiesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           shaderGroupHandleSize;
    ///             uint32_t           maxRayRecursionDepth;
    ///             uint32_t           maxShaderGroupStride;
    ///             uint32_t           shaderGroupBaseAlignment;
    ///             uint32_t           shaderGroupHandleCaptureReplaySize;
    ///             uint32_t           maxRayDispatchInvocationCount;
    ///             uint32_t           shaderGroupHandleAlignment;
    ///             uint32_t           maxRayHitAttributeSize;
    ///         } VkPhysicalDeviceRayTracingPipelinePropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRayTracingPipelinePropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderGroupHandleSize</c> is the size in bytes of the shader header.
        /// </summary>
        [FieldOffset(16)]
        public ByteSize32 ShaderGroupHandleSize;

        /// <summary>
        ///     <c>MaxRayRecursionDepth</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxRayRecursionDepth;

        /// <summary>
        ///     <c>MaxShaderGroupStride</c>
        /// </summary>
        [FieldOffset(24)]
        public ByteSize32 MaxShaderGroupStride;

        /// <summary>
        ///     <c>ShaderGroupBaseAlignment</c> is the required: alignment in bytes for the base of the shader binding table.
        /// </summary>
        [FieldOffset(28)]
        public ByteSize32 ShaderGroupBaseAlignment;

        /// <summary>
        ///     <c>ShaderGroupHandleCaptureReplaySize</c> is the number of bytes for the information required to do capture and replay for shader group handles.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize32 ShaderGroupHandleCaptureReplaySize;

        /// <summary>
        ///     <c>MaxRayDispatchInvocationCount</c> is the maximum number of ray generation shader invocations which may: be produced by a single <c>vkCmdTraceRaysIndirectKHR</c> or <c>vkCmdTraceRaysKHR</c> command.
        /// </summary>
        [FieldOffset(36)]
        public int MaxRayDispatchInvocationCount;

        /// <summary>
        ///     <c>ShaderGroupHandleAlignment</c> is the required: alignment in bytes for each entry in a shader binding table. The value <i>must</i> be a power of two.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize32 ShaderGroupHandleAlignment;

        /// <summary>
        ///     <c>MaxRayHitAttributeSize</c> is the maximum size in bytes for a ray attribute structure
        /// </summary>
        [FieldOffset(44)]
        public ByteSize32 MaxRayHitAttributeSize;
    }
}
