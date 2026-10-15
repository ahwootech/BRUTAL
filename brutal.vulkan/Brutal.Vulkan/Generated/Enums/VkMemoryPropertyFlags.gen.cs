namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryPropertyFlagBits.html">VkMemoryPropertyFlagBits</see> - Bitmask specifying properties for a memory type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which may: be set in <c>VkMemoryType::propertyFlags</c>,
    ///         indicating properties of a memory type, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkMemoryPropertyFlagBits {
    ///             VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = 0x00000001,
    ///             VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = 0x00000002,
    ///             VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = 0x00000004,
    ///             VK_MEMORY_PROPERTY_HOST_CACHED_BIT = 0x00000008,
    ///             VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = 0x00000010,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_MEMORY_PROPERTY_PROTECTED_BIT = 0x00000020,
    ///             // Provided by VK_AMD_device_coherent_memory
    ///             VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD = 0x00000040,
    ///             // Provided by VK_AMD_device_coherent_memory
    ///             VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD = 0x00000080,
    ///             // Provided by VK_NV_external_memory_rdma
    ///             VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV = 0x00000100,
    ///         } VkMemoryPropertyFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkMemoryPropertyFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>DeviceLocalBit</c> bit specifies that memory allocated with this type is the most efficient for device access. This property will be set if and only if the memory type belongs to a heap with the <c>VK_MEMORY_HEAP_DEVICE_LOCAL_BIT</c> set.
        /// </summary>
        DeviceLocalBit = 0x00000001,

        /// <summary>
        ///     <c>HostVisibleBit</c> bit specifies that memory allocated with this type <i>can</i> be mapped for host access using <c>vkMapMemory</c>.
        /// </summary>
        HostVisibleBit = 0x00000002,

        /// <summary>
        ///     <c>HostCoherentBit</c>
        /// </summary>
        HostCoherentBit = 0x00000004,

        /// <summary>
        ///     <c>HostCachedBit</c> bit specifies that memory allocated with this type is cached on the host. Host memory accesses to uncached memory are slower than to cached memory, however uncached memory is always host coherent.
        /// </summary>
        HostCachedBit = 0x00000008,

        /// <summary>
        ///     <c>LazilyAllocatedBit</c> bit specifies that the memory type only allows device access to the memory. Memory types <i>must</i> not have both <c>VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT</c> and <c>VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT</c> set. Additionally, the object&apos;s backing memory may: be provided by the implementation lazily as specified in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#memory-device-lazy_allocation">Lazily Allocated Memory^</see>.
        /// </summary>
        LazilyAllocatedBit = 0x00000010,

        /// <summary>
        ///     <c>ProtectedBit</c>
        /// </summary>
        ProtectedBit = 0x00000020,

        /// <summary>
        ///     <c>DeviceCoherentBitAMD</c>
        /// </summary>
        DeviceCoherentBitAMD = 0x00000040,

        /// <summary>
        ///     <c>DeviceUncachedBitAMD</c>
        /// </summary>
        DeviceUncachedBitAMD = 0x00000080,

        /// <summary>
        ///     <c>RdmaCapableBitNV</c>
        /// </summary>
        RdmaCapableBitNV = 0x00000100,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
