namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderStatisticsInfoAMD.html">VkShaderStatisticsInfoAMD</see> - Statistical information about a particular shader within a pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkShaderStatisticsInfoAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_shader_info
    ///         typedef struct VkShaderStatisticsInfoAMD {
    ///             VkShaderStageFlags          shaderStageMask;
    ///             VkShaderResourceUsageAMD    resourceUsage;
    ///             uint32_t                    numPhysicalVgprs;
    ///             uint32_t                    numPhysicalSgprs;
    ///             uint32_t                    numAvailableVgprs;
    ///             uint32_t                    numAvailableSgprs;
    ///             uint32_t                    computeWorkGroupSize[3];
    ///         } VkShaderStatisticsInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct VkShaderStatisticsInfoAMD()
    {
        /// <summary>
        ///     <c>ShaderStageMask</c> are the combination of logical shader stages contained within this shader.
        /// </summary>
        [FieldOffset(0)]
        public VkShaderStageFlags ShaderStageMask;

        /// <summary>
        ///     <c>ResourceUsage</c> is a <c>VkShaderResourceUsageAMD</c> structure describing internal physical device resources used by this shader.
        /// </summary>
        [FieldOffset(8)]
        public VkShaderResourceUsageAMD ResourceUsage;

        /// <summary>
        ///     <c>NumPhysicalVgprs</c> is the maximum number of vector instruction general-purpose registers (VGPRs) available to the physical device.
        /// </summary>
        [FieldOffset(40)]
        public int NumPhysicalVgprs;

        /// <summary>
        ///     <c>NumPhysicalSgprs</c> is the maximum number of scalar instruction general-purpose registers (SGPRs) available to the physical device.
        /// </summary>
        [FieldOffset(44)]
        public int NumPhysicalSgprs;

        /// <summary>
        ///     <c>NumAvailableVgprs</c> is the maximum limit of VGPRs made available to the shader compiler.
        /// </summary>
        [FieldOffset(48)]
        public int NumAvailableVgprs;

        /// <summary>
        ///     <c>NumAvailableSgprs</c> is the maximum limit of SGPRs made available to the shader compiler.
        /// </summary>
        [FieldOffset(52)]
        public int NumAvailableSgprs;

        /// <summary>
        ///     <c>ComputeWorkGroupSize</c> is the local workgroup size of this shader in { X, Y, Z } dimensions.
        /// </summary>
        [FieldOffset(56)]
        public uint3 ComputeWorkGroupSize;
    }
}
