namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerCubicWeightsCreateInfoQCOM.html">VkSamplerCubicWeightsCreateInfoQCOM</see> - Structure specifying sampler cubic weights
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSamplerCubicWeightsCreateInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_filter_cubic_weights
    ///         typedef struct VkSamplerCubicWeightsCreateInfoQCOM {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkCubicFilterWeightsQCOM    cubicWeights;
    ///         } VkSamplerCubicWeightsCreateInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSamplerCubicWeightsCreateInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerCubicWeightsCreateInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CubicWeights</c> is a <c>VkCubicFilterWeightsQCOM</c> value controlling which cubic weights are used.
        /// </summary>
        [FieldOffset(16)]
        public VkCubicFilterWeightsQCOM CubicWeights;
    }
}
