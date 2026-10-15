namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndirectStateFlagBitsNV.html">VkIndirectStateFlagBitsNV</see> - Bitmask specifying state that can be altered on the device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A subset of the graphics pipeline state <i>can</i> be altered using indirect state
    ///         flags:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands
    ///         typedef enum VkIndirectStateFlagBitsNV {
    ///             VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV = 0x00000001,
    ///         } VkIndirectStateFlagBitsNV;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkIndirectStateFlagsNV : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FlagFrontfaceBitNV</c> allows to toggle the <c>VkFrontFace</c> rasterization state for subsequent drawing commands.
        /// </summary>
        FlagFrontfaceBitNV = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumNV</c>
        /// </summary>
        FlagBitsMaxEnumNV = 0x7FFFFFFF,
    }
}
