namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorUsageFlagBitsARM.html">VkTensorUsageFlagBitsARM</see> - Bitmask specifying allowed usage of a tensor
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkTensorDescriptionARM::usage</c>,
    ///         specifying usage behavior of a tensor, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         // Flag bits for VkTensorUsageFlagBitsARM
    ///         typedef VkFlags64 VkTensorUsageFlagBitsARM;
    ///             static const VkTensorUsageFlagBitsARM VK_TENSOR_USAGE_SHADER_BIT_ARM = 0x00000002ULL;
    ///             static const VkTensorUsageFlagBitsARM VK_TENSOR_USAGE_TRANSFER_SRC_BIT_ARM = 0x00000004ULL;
    ///             static const VkTensorUsageFlagBitsARM VK_TENSOR_USAGE_TRANSFER_DST_BIT_ARM = 0x00000008ULL;
    ///             static const VkTensorUsageFlagBitsARM VK_TENSOR_USAGE_IMAGE_ALIASING_BIT_ARM = 0x00000010ULL;
    ///             // Provided by VK_ARM_data_graph
    ///             static const VkTensorUsageFlagBitsARM VK_TENSOR_USAGE_DATA_GRAPH_BIT_ARM = 0x00000020ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkTensorUsageFlagsARM : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ShaderBitARM</c> specifies that the tensor <i>can</i> be used to create a <c>VkTensorViewARM</c> suitable for occupying a <c>VkDescriptorSet</c> slot of type <c>VK_DESCRIPTOR_TYPE_TENSOR_ARM</c> accessed by shader stages.
        /// </summary>
        ShaderBitARM = 0x00000002,

        /// <summary>
        ///     <c>TransferSrcBitARM</c> specifies that the tensor <i>can</i> be used as the source of a <i>transfer command</i> (see the definition of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-pipeline-stages-transfer"><c>VK_PIPELINE_STAGE_TRANSFER_BIT</c>^</see>).
        /// </summary>
        TransferSrcBitARM = 0x00000004,

        /// <summary>
        ///     <c>TransferDstBitARM</c> specifies that the tensor <i>can</i> be used as the destination of a transfer command.
        /// </summary>
        TransferDstBitARM = 0x00000008,

        /// <summary>
        ///     <c>ImageAliasingBitARM</c> specifies that the tensor <i>can</i> be bound to a range of memory aliased with an image created with <c>VK_IMAGE_TILING_OPTIMAL</c>. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#resources-memory-aliasing">here</see> for a complete set of rules for tensor/image aliasing.
        /// </summary>
        ImageAliasingBitARM = 0x00000010,

        /// <summary>
        ///     <c>DataGraphBitARM</c>
        /// </summary>
        DataGraphBitARM = 0x00000020,
    }
}
