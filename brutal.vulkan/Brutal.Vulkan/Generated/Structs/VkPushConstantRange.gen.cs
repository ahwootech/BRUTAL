namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPushConstantRange.html">VkPushConstantRange</see> - Structure specifying a push constant range
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPushConstantRange</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPushConstantRange {
    ///             VkShaderStageFlags    stageFlags;
    ///             uint32_t              offset;
    ///             uint32_t              size;
    ///         } VkPushConstantRange;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkPushConstantRange()
    {
        /// <summary>
        ///     <c>StageFlags</c> is a set of stage flags describing the shader stages that will access a range of push constants. If a particular stage is not included in the range, then accessing members of that range of push constants from the corresponding shader stage will return undefined: values.
        /// </summary>
        [FieldOffset(0)]
        public VkShaderStageFlags StageFlags;

        /// <summary>
        ///     <c>Offset</c> and <c>size</c> are the start offset and size, respectively, consumed by the range. Both <c>offset</c> and <c>size</c> are in units of bytes and <i>must</i> be a multiple of 4. The layout of the push constant variables is specified in the shader.
        /// </summary>
        [FieldOffset(4)]
        public ByteSize32 Offset;

        /// <summary>
        ///     <c>Size</c>
        /// </summary>
        [FieldOffset(8)]
        public ByteSize32 Size;
    }
}
