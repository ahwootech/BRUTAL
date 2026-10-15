namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkViewportWScalingNV.html">VkViewportWScalingNV</see> - Structure specifying a viewport
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkViewportWScalingNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_clip_space_w_scaling
    ///         typedef struct VkViewportWScalingNV {
    ///             float    xcoeff;
    ///             float    ycoeff;
    ///         } VkViewportWScalingNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkViewportWScalingNV()
    {
        /// <summary>
        ///     <c>Xcoeff</c> and <c>ycoeff</c> are the viewport&apos;s W scaling factor for x and y respectively.
        /// </summary>
        [FieldOffset(0)]
        public float Xcoeff;

        /// <summary>
        ///     <c>Ycoeff</c>
        /// </summary>
        [FieldOffset(4)]
        public float Ycoeff;
    }
}
