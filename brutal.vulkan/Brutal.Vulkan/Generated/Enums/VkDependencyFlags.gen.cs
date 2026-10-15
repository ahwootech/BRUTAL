namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDependencyFlagBits.html">VkDependencyFlagBits</see> - Bitmask specifying how execution and memory dependencies are formed
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>vkCmdPipelineBarrier::dependencyFlags</c>,
    ///         specifying how execution and memory dependencies are formed, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkDependencyFlagBits {
    ///             VK_DEPENDENCY_BY_REGION_BIT = 0x00000001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_DEPENDENCY_DEVICE_GROUP_BIT = 0x00000004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_DEPENDENCY_VIEW_LOCAL_BIT = 0x00000002,
    ///             // Provided by VK_EXT_attachment_feedback_loop_layout
    ///             VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT = 0x00000008,
    ///             // Provided by VK_KHR_maintenance8
    ///             VK_DEPENDENCY_QUEUE_FAMILY_OWNERSHIP_TRANSFER_USE_ALL_STAGES_BIT_KHR = 0x00000020,
    ///             // Provided by VK_KHR_maintenance9
    ///             VK_DEPENDENCY_ASYMMETRIC_EVENT_BIT_KHR = 0x00000040,
    ///             // Provided by VK_KHR_multiview
    ///             VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR = VK_DEPENDENCY_VIEW_LOCAL_BIT,
    ///             // Provided by VK_KHR_device_group
    ///             VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR = VK_DEPENDENCY_DEVICE_GROUP_BIT,
    ///         } VkDependencyFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkDependencyFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ByRegionBit</c> specifies that dependencies will be split into multiple <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-framebuffer-regions">framebuffer-local regions^</see> according to the <c>(x,y,layer,sample)</c> coordinates.
        /// </summary>
        ByRegionBit = 0x00000001,

        /// <summary>
        ///     <c>DeviceGroupBit</c>
        /// </summary>
        DeviceGroupBit = 0x00000004,

        /// <summary>
        ///     <c>ViewLocalBit</c>
        /// </summary>
        ViewLocalBit = 0x00000002,

        /// <summary>
        ///     <c>FeedbackLoopBitEXT</c>
        /// </summary>
        FeedbackLoopBitEXT = 0x00000008,

        /// <summary>
        ///     <c>QueueFamilyOwnershipTransferUseAllStagesBitKHR</c>
        /// </summary>
        QueueFamilyOwnershipTransferUseAllStagesBitKHR = 0x00000020,

        /// <summary>
        ///     <c>AsymmetricEventBitKHR</c>
        /// </summary>
        AsymmetricEventBitKHR = 0x00000040,

        /// <summary>
        ///     <c>ViewLocalBitKHR</c>
        /// </summary>
        ViewLocalBitKHR = ViewLocalBit,

        /// <summary>
        ///     <c>DeviceGroupBitKHR</c>
        /// </summary>
        DeviceGroupBitKHR = DeviceGroupBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
