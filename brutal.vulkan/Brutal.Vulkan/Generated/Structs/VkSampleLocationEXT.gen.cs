namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSampleLocationEXT.html">VkSampleLocationEXT</see> - Structure specifying the coordinates of a sample location
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSampleLocationEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkSampleLocationEXT {
    ///             float    x;
    ///             float    y;
    ///         } VkSampleLocationEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkSampleLocationEXT()
    {
        /// <summary>
        ///     <c>X</c> is the horizontal coordinate of the sample&apos;s location.
        /// </summary>
        [FieldOffset(0)]
        public float X;

        /// <summary>
        ///     <c>Y</c> is the vertical coordinate of the sample&apos;s location.
        /// </summary>
        [FieldOffset(4)]
        public float Y;
    }
}
