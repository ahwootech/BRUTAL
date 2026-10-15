namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageViewSampleWeightCreateInfoQCOM.html">VkImageViewSampleWeightCreateInfoQCOM</see> - Structure describing weight sampling parameters for image view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain includes a
    ///         <c>VkImageViewSampleWeightCreateInfoQCOM</c> structure, then that structure
    ///         includes a parameter specifying the parameters for weight image views used
    ///         in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-weightimage">weight image sampling^</see>.
    ///     </para>
    ///     <para>
    ///         The <c>VkImageViewSampleWeightCreateInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_image_processing
    ///         typedef struct VkImageViewSampleWeightCreateInfoQCOM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkOffset2D         filterCenter;
    ///             VkExtent2D         filterSize;
    ///             uint32_t           numPhases;
    ///         } VkImageViewSampleWeightCreateInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkImageViewSampleWeightCreateInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImageViewSampleWeightCreateInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FilterCenter</c> is a <c>VkOffset2D</c> describing the location of the weight filter origin.
        /// </summary>
        [FieldOffset(16)]
        public VkOffset2D FilterCenter;

        /// <summary>
        ///     <c>FilterSize</c> is a <c>VkExtent2D</c> specifying weight filter dimensions.
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D FilterSize;

        /// <summary>
        ///     <c>NumPhases</c> is the number of sub-pixel filter phases.
        /// </summary>
        [FieldOffset(32)]
        public int NumPhases;
    }
}
