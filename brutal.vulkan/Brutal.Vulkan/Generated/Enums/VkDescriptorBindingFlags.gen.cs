namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorBindingFlagBits.html">VkDescriptorBindingFlagBits</see> - Bitmask specifying descriptor set layout binding properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in each element of
    ///         <c>VkDescriptorSetLayoutBindingFlagsCreateInfo::pBindingFlags</c>,
    ///         specifying options for the corresponding descriptor set layout binding, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef enum VkDescriptorBindingFlagBits {
    ///             VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT = 0x00000001,
    ///             VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT = 0x00000002,
    ///             VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT = 0x00000004,
    ///             VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT = 0x00000008,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT_EXT = VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT_EXT = VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT_EXT = VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT,
    ///         } VkDescriptorBindingFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDescriptorBindingFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>UpdateAfterBindBit</c> specifies that if descriptors in this binding are updated between when the descriptor set is bound in a command buffer and when that command buffer is submitted to a queue, then the submission will use the most recently set descriptors for this binding and the updates do not invalidate the command buffer. Descriptor bindings created with this flag are also partially exempt from the external synchronization requirement in <c>vkUpdateDescriptorSets</c>. Multiple descriptors with this flag set <i>can</i> be updated concurrently in different threads, though the same descriptor <i>must</i> not be updated concurrently by two threads. Descriptors with this flag set <i>can</i> be updated concurrently with the set being bound to a command buffer in another thread, but not concurrently with the set being reset or freed.
        /// </summary>
        UpdateAfterBindBit = 0x00000001,

        /// <summary>
        ///     <c>UpdateUnusedWhilePendingBit</c> specifies that descriptors in this binding <i>can</i> be updated after a command buffer has bound this descriptor set, or while a command buffer that uses this descriptor set is pending execution, as long as the descriptors that are updated are not used by those command buffers. Descriptor bindings created with this flag are also partially exempt from the external synchronization requirement in <c>vkUpdateDescriptorSets</c> in the same way as for <c>VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT</c>. If <c>VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT</c> is also set, then descriptors <i>can</i> be updated as long as they are not dynamically used by any shader invocations. If <c>VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT</c> is not set, then descriptors <i>can</i> be updated as long as they are not statically used by any shader invocations.
        /// </summary>
        UpdateUnusedWhilePendingBit = 0x00000002,

        /// <summary>
        ///     <c>PartiallyBoundBit</c> specifies that descriptors in this binding that are not <i>dynamically used</i> need not contain valid descriptors at the time the descriptors are consumed. A descriptor is dynamically used if any shader invocation executes an instruction that performs any memory access using the descriptor. If a descriptor is not dynamically used, any resource referenced by the descriptor is not considered to be referenced during command execution.
        /// </summary>
        PartiallyBoundBit = 0x00000004,

        /// <summary>
        ///     <c>VariableDescriptorCountBit</c> specifies that this is a _variable-sized descriptor binding_ whose size will be specified when a descriptor set is allocated using this layout. The value of <c>descriptorCount</c> is treated as an upper bound on the size of the binding. This <i>must</i> only be used for the last binding in the descriptor set layout (i.e. the binding with the largest value of <c>binding</c>). For the purposes of counting against limits such as <c>maxDescriptorSet</c>* and <c>maxPerStageDescriptor</c>*, the full value of <c>descriptorCount</c> is counted.  [NOTE]
        /// </summary>
        VariableDescriptorCountBit = 0x00000008,

        /// <summary>
        ///     <c>UpdateAfterBindBitEXT</c>
        /// </summary>
        UpdateAfterBindBitEXT = UpdateAfterBindBit,

        /// <summary>
        ///     <c>UpdateUnusedWhilePendingBitEXT</c>
        /// </summary>
        UpdateUnusedWhilePendingBitEXT = UpdateUnusedWhilePendingBit,

        /// <summary>
        ///     <c>PartiallyBoundBitEXT</c>
        /// </summary>
        PartiallyBoundBitEXT = PartiallyBoundBit,

        /// <summary>
        ///     <c>VariableDescriptorCountBitEXT</c>
        /// </summary>
        VariableDescriptorCountBitEXT = VariableDescriptorCountBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
