namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkComponentMapping.html">VkComponentMapping</see> - Structure specifying a color component mapping
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkComponentMapping</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkComponentMapping {
    ///             VkComponentSwizzle    r;
    ///             VkComponentSwizzle    g;
    ///             VkComponentSwizzle    b;
    ///             VkComponentSwizzle    a;
    ///         } VkComponentMapping;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkComponentMapping()
    {
        /// <summary>
        ///     <c>R</c> is a <c>VkComponentSwizzle</c> specifying the component value placed in the R component of the output vector.
        /// </summary>
        [FieldOffset(0)]
        public VkComponentSwizzle R;

        /// <summary>
        ///     <c>G</c> is a <c>VkComponentSwizzle</c> specifying the component value placed in the G component of the output vector.
        /// </summary>
        [FieldOffset(4)]
        public VkComponentSwizzle G;

        /// <summary>
        ///     <c>B</c> is a <c>VkComponentSwizzle</c> specifying the component value placed in the B component of the output vector.
        /// </summary>
        [FieldOffset(8)]
        public VkComponentSwizzle B;

        /// <summary>
        ///     <c>A</c> is a <c>VkComponentSwizzle</c> specifying the component value placed in the A component of the output vector.
        /// </summary>
        [FieldOffset(12)]
        public VkComponentSwizzle A;
    }
}
