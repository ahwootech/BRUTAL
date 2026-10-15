namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSchedulingControlsFlagBitsARM.html">VkPhysicalDeviceSchedulingControlsFlagBitsARM</see> - Bitmask specifying scheduling controls supported by a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkPhysicalDeviceSchedulingControlsPropertiesARM::schedulingControlsFlags</c>,
    ///         specifying supported scheduling controls, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_scheduling_controls
    ///         // Flag bits for VkPhysicalDeviceSchedulingControlsFlagBitsARM
    ///         typedef VkFlags64 VkPhysicalDeviceSchedulingControlsFlagBitsARM;
    ///             static const VkPhysicalDeviceSchedulingControlsFlagBitsARM VK_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_SHADER_CORE_COUNT_ARM = 0x00000001ULL;
    ///             static const VkPhysicalDeviceSchedulingControlsFlagBitsARM VK_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_DISPATCH_PARAMETERS_ARM = 0x00000002ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkPhysicalDeviceSchedulingControlsFlagsARM : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ShaderCoreCountARM</c>  specifies that a <c>VkDeviceQueueShaderCoreControlCreateInfoARM</c> structure may: be included in the <c>pNext</c> chain of a <c>VkDeviceQueueCreateInfo</c> or <c>VkDeviceCreateInfo</c> structure.
        /// </summary>
        ShaderCoreCountARM = 0x00000001,

        /// <summary>
        ///     <c>DispatchParametersARM</c>  specifies that a <c>vkCmdSetDispatchParametersARM</c> command may: be recorded in a command buffer and that properties returned in <c>VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM</c> are valid.
        /// </summary>
        DispatchParametersARM = 0x00000002,
    }
}
