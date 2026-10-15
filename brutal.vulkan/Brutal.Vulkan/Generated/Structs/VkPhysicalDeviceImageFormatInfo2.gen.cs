namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageFormatInfo2.html">VkPhysicalDeviceImageFormatInfo2</see> - Structure specifying image creation parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageFormatInfo2</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceImageFormatInfo2 {
    ///             VkStructureType       sType;
    ///             const void*           pNext;
    ///             VkFormat              format;
    ///             VkImageType           type;
    ///             VkImageTiling         tiling;
    ///             VkImageUsageFlags     usage;
    ///             VkImageCreateFlags    flags;
    ///         } VkPhysicalDeviceImageFormatInfo2;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceImageFormatInfo2()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageFormatInfo2;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure. The <c>pNext</c> chain of <c>VkPhysicalDeviceImageFormatInfo2</c> is used to provide additional image parameters to <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> value indicating the image format, corresponding to <c>VkImageCreateInfo::format</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat Format;

        /// <summary>
        ///     <c>Type</c> is a <c>VkImageType</c> value indicating the image type, corresponding to <c>VkImageCreateInfo::imageType</c>.
        /// </summary>
        [FieldOffset(20)]
        public VkImageType Type;

        /// <summary>
        ///     <c>Tiling</c> is a <c>VkImageTiling</c> value indicating the image tiling, corresponding to <c>VkImageCreateInfo::tiling</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkImageTiling Tiling;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkImageUsageFlags</c> indicating the intended usage of the image, corresponding to <c>VkImageCreateInfo::usage</c>.
        /// </summary>
        [FieldOffset(28)]
        public VkImageUsageFlags Usage;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkImageCreateFlags</c> indicating additional parameters of the image, corresponding to <c>VkImageCreateInfo::flags</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkImageCreateFlags Flags;
    }
}
