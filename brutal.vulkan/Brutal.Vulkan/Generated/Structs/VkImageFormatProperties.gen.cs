namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImageFormatProperties.html">VkImageFormatProperties</see> - Structure specifying an image format properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkImageFormatProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkImageFormatProperties {
    ///             VkExtent3D            maxExtent;
    ///             uint32_t              maxMipLevels;
    ///             uint32_t              maxArrayLayers;
    ///             VkSampleCountFlags    sampleCounts;
    ///             VkDeviceSize          maxResourceSize;
    ///         } VkImageFormatProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct VkImageFormatProperties()
    {
        /// <summary>
        ///     <c>MaxExtent</c> are the maximum image dimensions. See the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-extentperimagetype">Allowed Extent Values^</see> section below for how these values are constrained by <c>type</c>.
        /// </summary>
        [FieldOffset(0)]
        public VkExtent3D MaxExtent;

        /// <summary>
        ///     <c>MaxMipLevels</c> is the maximum number of mipmap levels. <c>maxMipLevels</c> <i>must</i> be equal to the number of levels in the complete mipmap chain based on the <c><c>maxExtent</c>.width</c>, <c><c>maxExtent</c>.height</c>, and <c><c>maxExtent</c>.depth</c>, except when one of the following conditions is true, in which case it may: instead be `1`:
        /// </summary>
        [FieldOffset(12)]
        public int MaxMipLevels;

        /// <summary>
        ///     <c>MaxArrayLayers</c> is the maximum number of array layers. <c>maxArrayLayers</c> <i>must</i> be no less than <c>VkPhysicalDeviceLimits::maxImageArrayLayers</c>, except when one of the following conditions is true, in which case it may: instead be `1`:
        /// </summary>
        [FieldOffset(16)]
        public int MaxArrayLayers;

        /// <summary>
        ///     <c>SampleCounts</c> is a bitmask of <c>VkSampleCountFlags</c> specifying all the supported sample counts for this image as described <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-supported-sample-counts">below^</see>.
        /// </summary>
        [FieldOffset(20)]
        public VkSampleCountFlags SampleCounts;

        /// <summary>
        ///     <c>MaxResourceSize</c> is an upper bound on the total image size in bytes, inclusive of all image subresources. Implementations may: have an address space limit on total size of a resource, which is advertised by this property. <c>maxResourceSize</c> <i>must</i> be at least 2^31^.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 MaxResourceSize;
    }
}
