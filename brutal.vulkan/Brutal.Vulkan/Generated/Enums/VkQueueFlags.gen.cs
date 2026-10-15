namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueueFlagBits.html">VkQueueFlagBits</see> - Bitmask specifying capabilities of queues in a queue family
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in <c>VkQueueFamilyProperties::queueFlags</c>,
    ///         indicating capabilities of queues in a queue family are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkQueueFlagBits {
    ///             VK_QUEUE_GRAPHICS_BIT = 0x00000001,
    ///             VK_QUEUE_COMPUTE_BIT = 0x00000002,
    ///             VK_QUEUE_TRANSFER_BIT = 0x00000004,
    ///             VK_QUEUE_SPARSE_BINDING_BIT = 0x00000008,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_QUEUE_PROTECTED_BIT = 0x00000010,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_QUEUE_VIDEO_DECODE_BIT_KHR = 0x00000020,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_QUEUE_VIDEO_ENCODE_BIT_KHR = 0x00000040,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_QUEUE_OPTICAL_FLOW_BIT_NV = 0x00000100,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_QUEUE_DATA_GRAPH_BIT_ARM = 0x00000400,
    ///         } VkQueueFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkQueueFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>GraphicsBit</c> specifies that queues in this queue family support graphics operations.
        /// </summary>
        GraphicsBit = 0x00000001,

        /// <summary>
        ///     <c>ComputeBit</c> specifies that queues in this queue family support compute operations.
        /// </summary>
        ComputeBit = 0x00000002,

        /// <summary>
        ///     <c>TransferBit</c> specifies that queues in this queue family support transfer operations.
        /// </summary>
        TransferBit = 0x00000004,

        /// <summary>
        ///     <c>SparseBindingBit</c> specifies that queues in this queue family support sparse memory management operations (see <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#sparsememory">Sparse Resources^</see>). If any of the sparse resource features are supported, then at least one queue family <i>must</i> support this bit.  At least one queue family of at least one physical device exposed by the implementation <i>must</i> support at least one of the following sets of operations:
        /// </summary>
        SparseBindingBit = 0x00000008,

        /// <summary>
        ///     <c>ProtectedBit</c>
        /// </summary>
        ProtectedBit = 0x00000010,

        /// <summary>
        ///     <c>VideoDecodeBitKHR</c>
        /// </summary>
        VideoDecodeBitKHR = 0x00000020,

        /// <summary>
        ///     <c>VideoEncodeBitKHR</c>
        /// </summary>
        VideoEncodeBitKHR = 0x00000040,

        /// <summary>
        ///     <c>OpticalFlowBitNV</c>
        /// </summary>
        OpticalFlowBitNV = 0x00000100,

        /// <summary>
        ///     <c>DataGraphBitARM</c>
        /// </summary>
        DataGraphBitARM = 0x00000400,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
