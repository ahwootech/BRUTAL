namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSpecializationMapEntry.html">VkSpecializationMapEntry</see> - Structure specifying a specialization map entry
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSpecializationMapEntry</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSpecializationMapEntry {
    ///             uint32_t    constantID;
    ///             uint32_t    offset;
    ///             size_t      size;
    ///         } VkSpecializationMapEntry;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkSpecializationMapEntry()
    {
        /// <summary>
        ///     <c>ConstantID</c> is the ID of the specialization constant in SPIR-V.
        /// </summary>
        [FieldOffset(0)]
        public int ConstantID;

        /// <summary>
        ///     <c>Offset</c> is the byte offset of the specialization constant value within the supplied data buffer.
        /// </summary>
        [FieldOffset(4)]
        public ByteSize32 Offset;

        /// <summary>
        ///     <c>Size</c> is the byte size of the specialization constant value within the supplied data buffer.
        /// </summary>
        [FieldOffset(8)]
        public ByteSize64 Size;
    }
}
