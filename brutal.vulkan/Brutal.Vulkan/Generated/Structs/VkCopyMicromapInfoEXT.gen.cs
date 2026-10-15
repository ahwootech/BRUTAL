namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMicromapInfoEXT.html">VkCopyMicromapInfoEXT</see> - Parameters for copying a micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMicromapInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkCopyMicromapInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkCopyMicromapInfoEXT {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkMicromapEXT            src;
    ///             VkMicromapEXT            dst;
    ///             VkCopyMicromapModeEXT    mode;
    ///         } VkCopyMicromapInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkCopyMicromapInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyMicromapInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Src</c> is the source micromap for the copy.
        /// </summary>
        [FieldOffset(16)]
        public VkMicromapEXT Src;

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
