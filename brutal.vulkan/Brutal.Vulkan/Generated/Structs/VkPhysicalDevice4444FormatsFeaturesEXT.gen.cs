namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevice4444FormatsFeaturesEXT.html">VkPhysicalDevice4444FormatsFeaturesEXT</see> - Structure describing additional 4444 formats supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevice4444FormatsFeaturesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_4444_formats
    ///         typedef struct VkPhysicalDevice4444FormatsFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           formatA4R4G4B4;
    ///             VkBool32           formatA4B4G4R4;
    ///         } VkPhysicalDevice4444FormatsFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDevice4444FormatsFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevice4444FormatsFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FormatA4R4G4B4</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FormatA4R4G4B4;

        /// <summary>
        ///     <c>FormatA4B4G4R4</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 FormatA4B4G4R4;
    }
}
