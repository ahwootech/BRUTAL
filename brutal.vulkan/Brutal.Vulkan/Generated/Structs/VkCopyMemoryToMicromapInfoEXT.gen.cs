namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryToMicromapInfoEXT.html">VkCopyMemoryToMicromapInfoEXT</see> - Parameters for deserializing a micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMemoryToMicromapInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyMemoryToMicromapInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkCopyMemoryToMicromapInfoEXT {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkDeviceOrHostAddressConstKHR    src;
    ///             VkMicromapEXT                    dst;
    ///             VkCopyMicromapModeEXT            mode;
    ///         } VkCopyMemoryToMicromapInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCopyMemoryToMicromapInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyMemoryToMicromapInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Src</c> is the device or host address of memory containing the source data for the copy.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceOrHostAddressConstKHR Src;

        /// <summary>
        ///     <c>Dst</c> is the target micromap for the copy.
        /// </summary>
        [FieldOffset(24)]
        public VkMicromapEXT Dst;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkCopyMicromapModeEXT</c> value specifying additional operations to perform during the copy.
        /// </summary>
        [FieldOffset(32)]
        public VkCopyMicromapModeEXT Mode;
    }
}
