namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBlitImageCubicWeightsInfoQCOM.html">VkBlitImageCubicWeightsInfoQCOM</see> - Structure specifying image blit cubic weight info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkBlitImageCubicWeightsInfoQCOM
    ///     </para>
    ///     <para>
    ///         The <c>VkBlitImageCubicWeightsInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_filter_cubic_weights
    ///         typedef struct VkBlitImageCubicWeightsInfoQCOM {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkCubicFilterWeightsQCOM    cubicWeights;
    ///         } VkBlitImageCubicWeightsInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBlitImageCubicWeightsInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BlitImageCubicWeightsInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CubicWeights</c> is a <c>VkCubicFilterWeightsQCOM</c> value controlling cubic filter weights for the blit.
        /// </summary>
        [FieldOffset(16)]
        public VkCubicFilterWeightsQCOM CubicWeights;
    }
}
