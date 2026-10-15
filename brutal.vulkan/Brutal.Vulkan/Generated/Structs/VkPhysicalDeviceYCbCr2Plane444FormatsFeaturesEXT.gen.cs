namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT.html">VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT</see> - Structure describing whether the implementation supports additional 2-plane 444 {YCbCr} formats
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_ycbcr_2plane_444_formats
    ///         typedef struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           ycbcr2plane444Formats;
    ///         } VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceYCbCr2Plane444FormatsFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceYCbCr2Plane444FormatsFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Ycbcr2plane444Formats</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Ycbcr2plane444Formats;
    }
}
