namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorViewCreateFlagBitsARM.html">VkTensorViewCreateFlagBitsARM</see> - Bitmask specifying additional parameters of an tensor view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkTensorViewCreateInfoARM::flags</c>,
    ///         specifying additional parameters of an tensor, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         // Flag bits for VkTensorViewCreateFlagBitsARM
    ///         typedef VkFlags64 VkTensorViewCreateFlagBitsARM;
    ///             // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///             static const VkTensorViewCreateFlagBitsARM VK_TENSOR_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_ARM = 0x00000001ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkTensorViewCreateFlagsARM : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitARM</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitARM = 0x00000001,
    }
}
