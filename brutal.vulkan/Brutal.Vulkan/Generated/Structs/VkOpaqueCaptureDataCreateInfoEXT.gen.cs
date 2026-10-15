namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDataCreateInfoEXT.html">VkOpaqueCaptureDataCreateInfoEXT</see> - Structure specifying opaque capture data
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOpaqueCaptureDataCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap
    ///         typedef struct VkOpaqueCaptureDataCreateInfoEXT {
    ///             VkStructureType                      sType;
    ///             const void*                          pNext;
    ///             const VkHostAddressRangeConstEXT*    pData;
    ///         } VkOpaqueCaptureDataCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkOpaqueCaptureDataCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.OpaqueCaptureDataCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Data</c> is a pointer to the range of host memory containing opaque data previously captured via <c>vkGetImageOpaqueCaptureDataEXT</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkHostAddressRangeConstEXT* Data;
    }
}
