namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerCustomBorderColorCreateInfoEXT.html">VkSamplerCustomBorderColorCreateInfoEXT</see> - Structure specifying custom border color
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         In addition to the predefined border color values, applications <i>can</i> provide
    ///         a custom border color value by including the
    ///         <c>VkSamplerCustomBorderColorCreateInfoEXT</c> structure in the
    ///         <c>VkSamplerCreateInfo::pNext</c> chain.
    ///     </para>
    ///     <para>
    ///         The <c>VkSamplerCustomBorderColorCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_custom_border_color
    ///         typedef struct VkSamplerCustomBorderColorCreateInfoEXT {
    ///             VkStructureType      sType;
    ///             const void*          pNext;
    ///             VkClearColorValue    customBorderColor;
    ///             VkFormat             format;
    ///         } VkSamplerCustomBorderColorCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkSamplerCustomBorderColorCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerCustomBorderColorCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CustomBorderColor</c> is a <c>VkClearColorValue</c> representing the desired custom sampler border color.
        /// </summary>
        [FieldOffset(16)]
        public VkClearColorValue CustomBorderColor;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> representing the format of the sampled image view(s). This field may be <c>VK_FORMAT_UNDEFINED</c> if the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-customBorderColorWithoutFormat"><c>customBorderColorWithoutFormat</c>^</see> feature is enabled.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat Format;
    }
}
