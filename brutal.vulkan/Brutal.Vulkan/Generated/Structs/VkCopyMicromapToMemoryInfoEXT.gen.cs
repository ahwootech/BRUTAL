namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMicromapToMemoryInfoEXT.html">VkCopyMicromapToMemoryInfoEXT</see> - Parameters for serializing a micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMicromapToMemoryInfoEXT
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkCopyMicromapToMemoryInfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkMicromapEXT               src;
    ///             VkDeviceOrHostAddressKHR    dst;
    ///             VkCopyMicromapModeEXT       mode;
    ///         } VkCopyMicromapToMemoryInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCopyMicromapToMemoryInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyMicromapToMemoryInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Src</c> is the source micromap for the copy
        /// </summary>
        [FieldOffset(16)]
        public VkMicromapEXT Src;

        /// <summary>
        ///     <c>Dst</c> is the device or host address of memory which is the target for the copy
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceOrHostAddressKHR Dst;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkCopyMicromapModeEXT</c> value specifying additional operations to perform during the copy.
        /// </summary>
        [FieldOffset(32)]
        public VkCopyMicromapModeEXT Mode;
    }
}
