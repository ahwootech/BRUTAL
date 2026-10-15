namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleLocationNV.html">VkCoarseSampleLocationNV</see> - Structure specifying parameters controlling shading rate image usage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCoarseSampleLocationNV</c> structure identifies a specific pixel and
    ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#primsrast-multisampling-coverage-mask">sample index^</see> for one of the
    ///         coverage samples in a fragment that is larger than one pixel.
    ///         This structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_shading_rate_image
    ///         typedef struct VkCoarseSampleLocationNV {
    ///             uint32_t    pixelX;
    ///             uint32_t    pixelY;
    ///             uint32_t    sample;
    ///         } VkCoarseSampleLocationNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkCoarseSampleLocationNV()
    {
        /// <summary>
        ///     <c>PixelX</c> is added to the x coordinate of the upper-leftmost pixel of each fragment to identify the pixel containing the coverage sample.
        /// </summary>
        [FieldOffset(0)]
        public int PixelX;

        /// <summary>
        ///     <c>PixelY</c> is added to the y coordinate of the upper-leftmost pixel of each fragment to identify the pixel containing the coverage sample.
        /// </summary>
        [FieldOffset(4)]
        public int PixelY;

        /// <summary>
        ///     <c>Sample</c> is the number of the coverage sample in the pixel identified by <c>pixelX</c> and <c>pixelY</c>.
        /// </summary>
        [FieldOffset(8)]
        public int Sample;
    }
}
