namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderResourceUsageAMD.html">VkShaderResourceUsageAMD</see> - Resource usage information about a particular shader within a pipeline
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkShaderResourceUsageAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_shader_info
    ///         typedef struct VkShaderResourceUsageAMD {
    ///             uint32_t    numUsedVgprs;
    ///             uint32_t    numUsedSgprs;
    ///             uint32_t    ldsSizePerLocalWorkGroup;
    ///             size_t      ldsUsageSizeInBytes;
    ///             size_t      scratchMemUsageInBytes;
    ///         } VkShaderResourceUsageAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct VkShaderResourceUsageAMD()
    {
        /// <summary>
        ///     <c>NumUsedVgprs</c> is the number of vector instruction general-purpose registers used by this shader.
        /// </summary>
        [FieldOffset(0)]
        public int NumUsedVgprs;

        /// <summary>
        ///     <c>NumUsedSgprs</c> is the number of scalar instruction general-purpose registers used by this shader.
        /// </summary>
        [FieldOffset(4)]
        public int NumUsedSgprs;

        /// <summary>
        ///     <c>LdsSizePerLocalWorkGroup</c> is the maximum local data store size per work group in bytes.
        /// </summary>
        [FieldOffset(8)]
        public int LdsSizePerLocalWorkGroup;

        /// <summary>
        ///     <c>LdsUsageSizeInBytes</c> is the LDS usage size in bytes per work group by this shader.
        /// </summary>
        [FieldOffset(16)]
        public nuint LdsUsageSizeInBytes;

        /// <summary>
        ///     <c>ScratchMemUsageInBytes</c> is the scratch memory usage in bytes by this shader.
        /// </summary>
        [FieldOffset(24)]
        public nuint ScratchMemUsageInBytes;
    }
}
