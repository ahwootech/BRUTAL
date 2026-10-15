namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolCreateFlagBits.html">VkDescriptorPoolCreateFlagBits</see> - Bitmask specifying certain supported operations on a descriptor pool
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkDescriptorPoolCreateInfo::flags</c>,
    ///         enabling operations on a descriptor pool, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkDescriptorPoolCreateFlagBits {
    ///             VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = 0x00000001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT = 0x00000002,
    ///             // Provided by VK_EXT_mutable_descriptor_type
    ///             VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT = 0x00000004,
    ///             // Provided by VK_NV_descriptor_pool_overallocation
    ///             VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV = 0x00000008,
    ///             // Provided by VK_NV_descriptor_pool_overallocation
    ///             VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV = 0x00000010,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT_EXT = VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT,
    ///             // Provided by VK_VALVE_mutable_descriptor_type
    ///             VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_VALVE = VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT,
    ///         } VkDescriptorPoolCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDescriptorPoolCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FreeDescriptorSetBit</c> specifies that descriptor sets <i>can</i> return their individual allocations to the pool, i.e. all of <c>vkAllocateDescriptorSets</c>, <c>vkFreeDescriptorSets</c>, and <c>vkResetDescriptorPool</c> are allowed. Otherwise, descriptor sets allocated from the pool <i>must</i> not be individually freed back to the pool, i.e. only <c>vkAllocateDescriptorSets</c> and <c>vkResetDescriptorPool</c> are allowed.
        /// </summary>
        FreeDescriptorSetBit = 0x00000001,

        /// <summary>
        ///     <c>UpdateAfterBindBit</c>
        /// </summary>
        UpdateAfterBindBit = 0x00000002,

        /// <summary>
        ///     <c>HostOnlyBitEXT</c>
        /// </summary>
        HostOnlyBitEXT = 0x00000004,

        /// <summary>
        ///     <c>AllowOverallocationSetsBitNV</c>
        /// </summary>
        AllowOverallocationSetsBitNV = 0x00000008,

        /// <summary>
        ///     <c>AllowOverallocationPoolsBitNV</c>
        /// </summary>
        AllowOverallocationPoolsBitNV = 0x00000010,

        /// <summary>
        ///     <c>UpdateAfterBindBitEXT</c>
        /// </summary>
        UpdateAfterBindBitEXT = UpdateAfterBindBit,

        /// <summary>
        ///     <c>HostOnlyBitVALVE</c>
        /// </summary>
        HostOnlyBitVALVE = HostOnlyBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
