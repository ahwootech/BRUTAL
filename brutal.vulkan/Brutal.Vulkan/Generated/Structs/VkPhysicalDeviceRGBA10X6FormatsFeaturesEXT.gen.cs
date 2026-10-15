namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT.html">VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT</see> - Structure describing whether rendering to VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 formats can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_rgba10x6_formats
    ///         typedef struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           formatRgba10x6WithoutYCbCrSampler;
    ///         } VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRgba10X6FormatsFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FormatRgba10x6WithoutYCbCrSampler</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FormatRgba10x6WithoutYCbCrSampler;
    }
}
