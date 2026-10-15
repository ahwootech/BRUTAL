namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerReductionModeCreateInfo.html">VkSamplerReductionModeCreateInfo</see> - Structure specifying sampler reduction mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSamplerReductionModeCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkSamplerReductionModeCreateInfo {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkSamplerReductionMode    reductionMode;
    ///         } VkSamplerReductionModeCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSamplerReductionModeCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerReductionModeCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ReductionMode</c> is a <c>VkSamplerReductionMode</c> value controlling how texture filtering combines texel values.
        /// </summary>
        [FieldOffset(16)]
        public VkSamplerReductionMode ReductionMode;
    }
}
