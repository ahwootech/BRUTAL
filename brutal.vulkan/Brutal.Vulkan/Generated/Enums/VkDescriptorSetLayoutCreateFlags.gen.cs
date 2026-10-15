namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutCreateFlagBits.html">VkDescriptorSetLayoutCreateFlagBits</see> - Bitmask specifying descriptor set layout properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkDescriptorSetLayoutCreateInfo::flags</c>, specifying options for
    ///         descriptor set layout, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkDescriptorSetLayoutCreateFlagBits {
    ///             // Provided by VK_VERSION_1_2
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT = 0x00000002,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT = 0x00000001,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT = 0x00000010,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT = 0x00000020,
    ///             // Provided by VK_NV_device_generated_commands_compute
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_INDIRECT_BINDABLE_BIT_NV = 0x00000080,
    ///             // Provided by VK_EXT_mutable_descriptor_type
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT = 0x00000004,
    ///             // Provided by VK_NV_per_stage_descriptor_set
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_PER_STAGE_BIT_NV = 0x00000040,
    ///             // Provided by VK_KHR_push_descriptor
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR = VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT = VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT,
    ///             // Provided by VK_VALVE_mutable_descriptor_type
    ///             VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE = VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT,
    ///         } VkDescriptorSetLayoutCreateFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDescriptorSetLayoutCreateFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>UpdateAfterBindPoolBit</c>
        /// </summary>
        UpdateAfterBindPoolBit = 0x00000002,

        /// <summary>
        ///     <c>PushDescriptorBit</c>
        /// </summary>
        PushDescriptorBit = 0x00000001,

        /// <summary>
        ///     <c>DescriptorBufferBitEXT</c>
        /// </summary>
        DescriptorBufferBitEXT = 0x00000010,

        /// <summary>
        ///     <c>EmbeddedImmutableSamplersBitEXT</c>
        /// </summary>
        EmbeddedImmutableSamplersBitEXT = 0x00000020,

        /// <summary>
        ///     <c>IndirectBindableBitNV</c>
        /// </summary>
        IndirectBindableBitNV = 0x00000080,

        /// <summary>
        ///     <c>HostOnlyPoolBitEXT</c>
        /// </summary>
        HostOnlyPoolBitEXT = 0x00000004,

        /// <summary>
        ///     <c>PerStageBitNV</c>
        /// </summary>
        PerStageBitNV = 0x00000040,

        /// <summary>
        ///     <c>PushDescriptorBitKHR</c>
        /// </summary>
        PushDescriptorBitKHR = PushDescriptorBit,

        /// <summary>
        ///     <c>UpdateAfterBindPoolBitEXT</c>
        /// </summary>
        UpdateAfterBindPoolBitEXT = UpdateAfterBindPoolBit,

        /// <summary>
        ///     <c>HostOnlyPoolBitVALVE</c>
        /// </summary>
        HostOnlyPoolBitVALVE = HostOnlyPoolBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
