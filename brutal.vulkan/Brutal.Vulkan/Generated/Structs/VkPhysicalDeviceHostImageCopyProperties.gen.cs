namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceHostImageCopyProperties.html">VkPhysicalDeviceHostImageCopyProperties</see> - Structure enumerating image layouts supported by an implementation for host memory copies
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceHostImageCopyProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceHostImageCopyProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           copySrcLayoutCount;
    ///             VkImageLayout*     pCopySrcLayouts;
    ///             uint32_t           copyDstLayoutCount;
    ///             VkImageLayout*     pCopyDstLayouts;
    ///             uint8_t            optimalTilingLayoutUUID[VK_UUID_SIZE];
    ///             VkBool32           identicalMemoryTypeRequirements;
    ///         } VkPhysicalDeviceHostImageCopyProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkPhysicalDeviceHostImageCopyProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceHostImageCopyProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CopySrcLayoutCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int CopySrcLayoutCount;

        /// <summary>
        ///     <c>CopySrcLayouts</c>
        /// </summary>
        [FieldOffset(24)]
        public VkImageLayout* CopySrcLayouts;

        /// <summary>
        ///     <c>CopyDstLayoutCount</c>
        /// </summary>
        [FieldOffset(32)]
        public int CopyDstLayoutCount;

        /// <summary>
        ///     <c>CopyDstLayouts</c>
        /// </summary>
        [FieldOffset(40)]
        public VkImageLayout* CopyDstLayouts;

        ///
        [FieldOffset(48)]
        public fixed byte OptimalTilingLayoutUUID[16];

        /// <summary>
        ///     <c>IdenticalMemoryTypeRequirements</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 IdenticalMemoryTypeRequirements;
    }
}
