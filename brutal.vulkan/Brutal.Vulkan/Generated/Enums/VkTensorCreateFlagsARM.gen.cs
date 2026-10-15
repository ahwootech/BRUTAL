namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorCreateFlagBitsARM.html">VkTensorCreateFlagBitsARM</see> - Bitmask specifying additional parameters of a tensor
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkTensorCreateInfoARM::flags</c>,
    ///         specifying additional parameters of a tensor, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         // Flag bits for VkTensorCreateFlagBitsARM
    ///         typedef VkFlags64 VkTensorCreateFlagBitsARM;
    ///             static const VkTensorCreateFlagBitsARM VK_TENSOR_CREATE_MUTABLE_FORMAT_BIT_ARM = 0x00000001ULL;
    ///             static const VkTensorCreateFlagBitsARM VK_TENSOR_CREATE_PROTECTED_BIT_ARM = 0x00000002ULL;
    ///             // Provided by VK_EXT_descriptor_heap with VK_ARM_tensors
    ///             static const VkTensorCreateFlagBitsARM VK_TENSOR_CREATE_DESCRIPTOR_HEAP_CAPTURE_REPLAY_BIT_ARM = 0x00000008ULL;
    ///             // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///             static const VkTensorCreateFlagBitsARM VK_TENSOR_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM = 0x00000004ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkTensorCreateFlagsARM : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>MutableFormatBitARM</c> specifies that the tensor <i>can</i> be used to create a <c>VkTensorViewARM</c> with a different format from the tensor.
        /// </summary>
        MutableFormatBitARM = 0x00000001,

        /// <summary>
        ///     <c>ProtectedBitARM</c> specifies that the tensor is a protected tensor.
        /// </summary>
        ProtectedBitARM = 0x00000002,

        /// <summary>
        ///     <c>DescriptorHeapCaptureReplayBitARM</c>
        /// </summary>
        DescriptorHeapCaptureReplayBitARM = 0x00000008,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitARM</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitARM = 0x00000004,
    }
}
