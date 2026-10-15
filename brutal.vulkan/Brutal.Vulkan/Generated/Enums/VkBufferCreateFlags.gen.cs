namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBufferCreateFlagBits.html">VkBufferCreateFlagBits</see> - Bitmask specifying additional parameters of a buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkBufferCreateInfo::flags</c>, specifying
    ///         additional parameters of a buffer, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkBufferCreateFlagBits {
    ///             VK_BUFFER_CREATE_SPARSE_BINDING_BIT = 0x00000001,
    ///             VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = 0x00000002,
    ///             VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = 0x00000004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_BUFFER_CREATE_PROTECTED_BIT = 0x00000008,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = 0x00000010,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x00000020,
    ///             // Provided by VK_KHR_video_maintenance1
    ///             VK_BUFFER_CREATE_VIDEO_PROFILE_INDEPENDENT_BIT_KHR = 0x00000040,
    ///             // Provided by VK_EXT_buffer_device_address
    ///             VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
    ///         } VkBufferCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkBufferCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>SparseBindingBit</c> specifies that the buffer will be backed using sparse memory binding.
        /// </summary>
        SparseBindingBit = 0x00000001,

        /// <summary>
        ///     <c>SparseResidencyBit</c> specifies that the buffer <i>can</i> be partially backed using sparse memory binding. Buffers created with this flag <i>must</i> also be created with the <c>VK_BUFFER_CREATE_SPARSE_BINDING_BIT</c> flag.
        /// </summary>
        SparseResidencyBit = 0x00000002,

        /// <summary>
        ///     <c>SparseAliasedBit</c> specifies that the buffer will be backed using sparse memory binding with memory ranges that might also simultaneously be backing another buffer (or another portion of the same buffer). Buffers created with this flag <i>must</i> also be created with the <c>VK_BUFFER_CREATE_SPARSE_BINDING_BIT</c> flag.  See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#sparsememory-sparseresourcefeatures">Sparse Resource Features^</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features">Physical Device Features^</see> for details of the sparse memory features supported on a device.
        /// </summary>
        SparseAliasedBit = 0x00000004,

        /// <summary>
        ///     <c>ProtectedBit</c>
        /// </summary>
        ProtectedBit = 0x00000008,

        /// <summary>
        ///     <c>DeviceAddressCaptureReplayBit</c>
        /// </summary>
        DeviceAddressCaptureReplayBit = 0x00000010,

        /// <summary>
        ///     <c>DescriptorBufferCaptureReplayBitEXT</c>
        /// </summary>
        DescriptorBufferCaptureReplayBitEXT = 0x00000020,

        /// <summary>
        ///     <c>VideoProfileIndependentBitKHR</c>
        /// </summary>
        VideoProfileIndependentBitKHR = 0x00000040,

        /// <summary>
        ///     <c>DeviceAddressCaptureReplayBitEXT</c>
        /// </summary>
        DeviceAddressCaptureReplayBitEXT = DeviceAddressCaptureReplayBit,

        /// <summary>
        ///     <c>DeviceAddressCaptureReplayBitKHR</c>
        /// </summary>
        DeviceAddressCaptureReplayBitKHR = DeviceAddressCaptureReplayBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
