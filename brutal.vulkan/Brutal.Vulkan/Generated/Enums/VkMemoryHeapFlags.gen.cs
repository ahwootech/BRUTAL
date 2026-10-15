namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryHeapFlagBits.html">VkMemoryHeapFlagBits</see> - Bitmask specifying attribute flags for a heap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in <c>VkMemoryHeap::flags</c>, indicating
    ///         attribute flags for the heap, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkMemoryHeapFlagBits {
    ///             VK_MEMORY_HEAP_DEVICE_LOCAL_BIT = 0x00000001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_MEMORY_HEAP_MULTI_INSTANCE_BIT = 0x00000002,
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             VK_MEMORY_HEAP_TILE_MEMORY_BIT_QCOM = 0x00000008,
    ///             // Provided by VK_KHR_device_group_creation
    ///             VK_MEMORY_HEAP_MULTI_INSTANCE_BIT_KHR = VK_MEMORY_HEAP_MULTI_INSTANCE_BIT,
    ///         } VkMemoryHeapFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkMemoryHeapFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DeviceLocalBit</c> specifies that the heap corresponds to device-local memory. Device-local memory may: have different performance characteristics than host-local memory, and may: support different memory property flags.
        /// </summary>
        DeviceLocalBit = 0x00000001,

        /// <summary>
        ///     <c>MultiInstanceBit</c>
        /// </summary>
        MultiInstanceBit = 0x00000002,

        /// <summary>
        ///     <c>TileMemoryBitQCOM</c>
        /// </summary>
        TileMemoryBitQCOM = 0x00000008,

        /// <summary>
        ///     <c>MultiInstanceBitKHR</c>
        /// </summary>
        MultiInstanceBitKHR = MultiInstanceBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
