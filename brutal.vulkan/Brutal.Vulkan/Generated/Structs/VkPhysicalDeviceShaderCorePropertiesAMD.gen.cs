namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderCorePropertiesAMD.html">VkPhysicalDeviceShaderCorePropertiesAMD</see> - Structure describing shader core properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderCorePropertiesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_shader_core_properties
    ///         typedef struct VkPhysicalDeviceShaderCorePropertiesAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           shaderEngineCount;
    ///             uint32_t           shaderArraysPerEngineCount;
    ///             uint32_t           computeUnitsPerShaderArray;
    ///             uint32_t           simdPerComputeUnit;
    ///             uint32_t           wavefrontsPerSimd;
    ///             uint32_t           wavefrontSize;
    ///             uint32_t           sgprsPerSimd;
    ///             uint32_t           minSgprAllocation;
    ///             uint32_t           maxSgprAllocation;
    ///             uint32_t           sgprAllocationGranularity;
    ///             uint32_t           vgprsPerSimd;
    ///             uint32_t           minVgprAllocation;
    ///             uint32_t           maxVgprAllocation;
    ///             uint32_t           vgprAllocationGranularity;
    ///         } VkPhysicalDeviceShaderCorePropertiesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderCorePropertiesAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderEngineCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int ShaderEngineCount;

        /// <summary>
        ///     <c>ShaderArraysPerEngineCount</c>
        /// </summary>
        [FieldOffset(20)]
        public int ShaderArraysPerEngineCount;

        /// <summary>
        ///     <c>ComputeUnitsPerShaderArray</c>
        /// </summary>
        [FieldOffset(24)]
        public int ComputeUnitsPerShaderArray;

        /// <summary>
        ///     <c>SimdPerComputeUnit</c>
        /// </summary>
        [FieldOffset(28)]
        public int SimdPerComputeUnit;

        /// <summary>
        ///     <c>WavefrontsPerSimd</c>
        /// </summary>
        [FieldOffset(32)]
        public int WavefrontsPerSimd;

        /// <summary>
        ///     <c>WavefrontSize</c>
        /// </summary>
        [FieldOffset(36)]
        public int WavefrontSize;

        /// <summary>
        ///     <c>SgprsPerSimd</c>
        /// </summary>
        [FieldOffset(40)]
        public int SgprsPerSimd;

        /// <summary>
        ///     <c>MinSgprAllocation</c>
        /// </summary>
        [FieldOffset(44)]
        public int MinSgprAllocation;

        /// <summary>
        ///     <c>MaxSgprAllocation</c>
        /// </summary>
        [FieldOffset(48)]
        public int MaxSgprAllocation;

        /// <summary>
        ///     <c>SgprAllocationGranularity</c>
        /// </summary>
        [FieldOffset(52)]
        public int SgprAllocationGranularity;

        /// <summary>
        ///     <c>VgprsPerSimd</c>
        /// </summary>
        [FieldOffset(56)]
        public int VgprsPerSimd;

        /// <summary>
        ///     <c>MinVgprAllocation</c>
        /// </summary>
        [FieldOffset(60)]
        public int MinVgprAllocation;

        /// <summary>
        ///     <c>MaxVgprAllocation</c>
        /// </summary>
        [FieldOffset(64)]
        public int MaxVgprAllocation;

        /// <summary>
        ///     <c>VgprAllocationGranularity</c>
        /// </summary>
        [FieldOffset(68)]
        public int VgprAllocationGranularity;
    }
}
