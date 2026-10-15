namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateType.html">VkDescriptorUpdateTemplateType</see> - Indicates the valid usage of the descriptor update template
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The descriptor update template type is determined by the
    ///         <c>VkDescriptorUpdateTemplateCreateInfo::templateType</c> property,
    ///         which takes the following values:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkDescriptorUpdateTemplateType {
    ///             VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET = 0,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS = 1,
    ///             // Provided by VK_KHR_descriptor_update_template with VK_KHR_push_descriptor, VK_KHR_push_descriptor with VK_VERSION_1_1 or VK_KHR_descriptor_update_template
    ///             VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR = VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS,
    ///             // Provided by VK_KHR_descriptor_update_template
    ///             VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET_KHR = VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET,
    ///         } VkDescriptorUpdateTemplateType;
    ///     </code>
    /// </remarks>
    public enum VkDescriptorUpdateTemplateType : int
    {
        /// <summary>
        ///     <c>DescriptorSet</c> specifies that the descriptor update template will be used for descriptor set updates only.
        /// </summary>
        DescriptorSet = 0,

        /// <summary>
        ///     <c>PushDescriptors</c>
        /// </summary>
        PushDescriptors = 1,

        /// <summary>
        ///     <c>PushDescriptorsKHR</c>
        /// </summary>
        PushDescriptorsKHR = PushDescriptors,

        /// <summary>
        ///     <c>DescriptorSetKHR</c>
        /// </summary>
        DescriptorSetKHR = DescriptorSet,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
