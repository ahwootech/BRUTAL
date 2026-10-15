namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingFlagBits.html">VkRenderingFlagBits</see> - Bitmask specifying additional properties of a dynamic render pass instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in <c>VkRenderingInfo::flags</c> describing
    ///         additional properties of the render pass are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef enum VkRenderingFlagBits {
    ///             VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT = 0x00000001,
    ///             VK_RENDERING_SUSPENDING_BIT = 0x00000002,
    ///             VK_RENDERING_RESUMING_BIT = 0x00000004,
    ///             // Provided by VK_EXT_legacy_dithering with (VK_KHR_dynamic_rendering or VK_VERSION_1_3) and (VK_VERSION_1_4 or VK_KHR_extended_flags or VK_KHR_maintenance5)
    ///             VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT = 0x00000008,
    ///             // Provided by VK_KHR_maintenance7
    ///             VK_RENDERING_CONTENTS_INLINE_BIT_KHR = 0x00000010,
    ///             // Provided by VK_VALVE_fragment_density_map_layered
    ///             VK_RENDERING_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE = 0x00000020,
    ///             // Provided by VK_EXT_custom_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///             VK_RENDERING_FRAGMENT_REGION_BIT_EXT = 0x00000040,
    ///             // Provided by VK_EXT_custom_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///             VK_RENDERING_CUSTOM_RESOLVE_BIT_EXT = 0x00000080,
    ///             // Provided by VK_KHR_maintenance10 with (VK_VERSION_1_4 or VK_KHR_dynamic_rendering_local_read) and (VK_VERSION_1_3 or VK_KHR_dynamic_rendering)
    ///             VK_RENDERING_LOCAL_READ_CONCURRENT_ACCESS_CONTROL_BIT_KHR = 0x00000100,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR = VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_RENDERING_SUSPENDING_BIT_KHR = VK_RENDERING_SUSPENDING_BIT,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_RENDERING_RESUMING_BIT_KHR = VK_RENDERING_RESUMING_BIT,
    ///             // Provided by VK_EXT_nested_command_buffer
    ///             VK_RENDERING_CONTENTS_INLINE_BIT_EXT = VK_RENDERING_CONTENTS_INLINE_BIT_KHR,
    ///         } VkRenderingFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkRenderingFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ContentsSecondaryCommandBuffersBit</c> specifies that contents for the render pass instance will be recorded in secondary command buffers, and <c>vkCmdExecuteCommands</c> is the only valid command in the command buffer until <c>vkCmdEndRendering</c>.
        /// </summary>
        ContentsSecondaryCommandBuffersBit = 0x00000001,

        /// <summary>
        ///     <c>SuspendingBit</c> specifies that the render pass instance will be suspended.  [[renderpass-suspension]] The contents of <c>pRenderingInfo</c> <i>must</i> match between suspended render pass instances and the render pass instances that resume them, other than the presence or absence of the <c>VK_RENDERING_RESUMING_BIT</c>, <c>VK_RENDERING_SUSPENDING_BIT</c>, and <c>VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT</c> flags. No action or synchronization commands, or other render pass instances, are allowed between suspending and resuming render pass instances.
        /// </summary>
        SuspendingBit = 0x00000002,

        /// <summary>
        ///     <c>ResumingBit</c> specifies that the render pass instance is resuming an earlier suspended render pass instance.
        /// </summary>
        ResumingBit = 0x00000004,

        /// <summary>
        ///     <c>EnableLegacyDitheringBitEXT</c>
        /// </summary>
        EnableLegacyDitheringBitEXT = 0x00000008,

        /// <summary>
        ///     <c>ContentsInlineBitKHR</c>
        /// </summary>
        ContentsInlineBitKHR = 0x00000010,

        /// <summary>
        ///     <c>PerLayerFragmentDensityBitVALVE</c>
        /// </summary>
        PerLayerFragmentDensityBitVALVE = 0x00000020,

        /// <summary>
        ///     <c>FragmentRegionBitEXT</c>
        /// </summary>
        FragmentRegionBitEXT = 0x00000040,

        /// <summary>
        ///     <c>CustomResolveBitEXT</c>
        /// </summary>
        CustomResolveBitEXT = 0x00000080,

        /// <summary>
        ///     <c>LocalReadConcurrentAccessControlBitKHR</c>
        /// </summary>
        LocalReadConcurrentAccessControlBitKHR = 0x00000100,

        /// <summary>
        ///     <c>ContentsSecondaryCommandBuffersBitKHR</c>
        /// </summary>
        ContentsSecondaryCommandBuffersBitKHR = ContentsSecondaryCommandBuffersBit,

        /// <summary>
        ///     <c>SuspendingBitKHR</c>
        /// </summary>
        SuspendingBitKHR = SuspendingBit,

        /// <summary>
        ///     <c>ResumingBitKHR</c>
        /// </summary>
        ResumingBitKHR = ResumingBit,

        /// <summary>
        ///     <c>ContentsInlineBitEXT</c>
        /// </summary>
        ContentsInlineBitEXT = ContentsInlineBitKHR,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
