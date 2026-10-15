namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerCustomBorderColorIndexCreateInfoEXT.html">VkSamplerCustomBorderColorIndexCreateInfoEXT</see> - Structure specifying the custom border color index for a sampler
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSamplerCustomBorderColorIndexCreateInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_custom_border_color with VK_EXT_descriptor_heap
    ///         typedef struct VkSamplerCustomBorderColorIndexCreateInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           index;
    ///         } VkSamplerCustomBorderColorIndexCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkSamplerCustomBorderColorIndexCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerCustomBorderColorIndexCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Index</c> is the <c>uint32_t</c> index value to use with the sampler
        /// </summary>
        [FieldOffset(16)]
        public int Index;
    }
}
