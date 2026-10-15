namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerBlockMatchWindowCreateInfoQCOM.html">VkSamplerBlockMatchWindowCreateInfoQCOM</see> - Structure specifying the block match window parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSamplerBlockMatchWindowCreateInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_image_processing2
    ///         typedef struct VkSamplerBlockMatchWindowCreateInfoQCOM {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             VkExtent2D                           windowExtent;
    ///             VkBlockMatchWindowCompareModeQCOM    windowCompareMode;
    ///         } VkSamplerBlockMatchWindowCreateInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkSamplerBlockMatchWindowCreateInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerBlockMatchWindowCreateInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WindowExtent</c> is a <c>VkExtent2D</c> specifying a the width and height of the block match window.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D WindowExtent;

        /// <summary>
        ///     <c>WindowCompareMode</c> is a <c>VkBlockMatchWindowCompareModeQCOM</c> specifying the compare mode.
        /// </summary>
        [FieldOffset(24)]
        public VkBlockMatchWindowCompareModeQCOM WindowCompareMode;
    }
}
