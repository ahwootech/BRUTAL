namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMultisamplePropertiesEXT.html">VkMultisamplePropertiesEXT</see> - Structure returning information about sample count specific additional multisampling capabilities
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMultisamplePropertiesEXT</c> structure is defined as
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkMultisamplePropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkExtent2D         maxSampleLocationGridSize;
    ///         } VkMultisamplePropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMultisamplePropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MultisamplePropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxSampleLocationGridSize</c> is the maximum size of the pixel grid in which sample locations <i>can</i> vary.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D MaxSampleLocationGridSize;
    }
}
